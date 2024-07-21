using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    public partial class ShooterLvlOne : Form
    {
        public ShooterLvlOne()
        {
            InitializeComponent();
            new Enemies().CreateSprites(this);
            InsertAliens();
        }
        List<PictureBox> aliens = new List<PictureBox>();
        List<PictureBox> delay = new List<PictureBox>();

        const int x = 360, y = 650;
        const int limit = 730;

        int speed = -1;
        int left = -1;
        int top = 0;
        int cnt = 0;
        int enem = 50;

        bool game = true;
        bool moveLeft;
        bool moveRight;
        bool fired;

        private void Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            else if (e.KeyCode == Keys.Space && game && !fired)
            {
                Missile();
                fired = true;
            }
        }

        private void Released(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                fired = false;
            }
        }

        private void PlayerMove(object sender, EventArgs e)
        {
            if (moveLeft && Player.Location.X >= 0)
            {
                Player.Left -= 5;
            }
            else if (moveRight && Player.Location.X <= limit)
            {
                Player.Left += 5;
            }
        }


        //Space
        private void FireBullet(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Bullet")
                {
                    PictureBox bullet = (PictureBox)c;
                    bullet.Top -= 5;

                    if (bullet.Location.Y <= 0)
                    {
                        this.Controls.Remove(bullet);
                    }

                    foreach (Control ct in this.Controls)
                    {
                        if (ct is PictureBox && ct.Name == "Laser")
                        {
                            PictureBox laser = (PictureBox)ct;

                            if (bullet.Bounds.IntersectsWith(laser.Bounds))
                            {
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(laser);
                                // pts += 5;
                                //Score(pts);
                            }
                        }
                    }

                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Name == "Alien")
                        {
                            PictureBox alien = (PictureBox)ctrl;

                            if (bullet.Bounds.IntersectsWith(alien.Bounds) && !Touched(alien))
                            {
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(alien);
                                aliens.Remove(alien);
                                enem--;
                                EnemyNum(enem);
                                CheckForWinner();
                            }
                            else if (bullet.Bounds.IntersectsWith(alien.Bounds) && Touched(alien))
                            {
                                this.Controls.Remove(bullet);
                                this.Controls.Remove(alien);
                                delay.Add(alien);
                                enem--;
                                EnemyNum(enem);
                                CheckForWinner();
                            }
                        }
                    }
                }
            }
        }

        private void Missile()
        {
            PictureBox bullet = new PictureBox();
            bullet.Location = new Point(Player.Location.X + Player.Width / 2, Player.Location.Y - 20);
            bullet.Size = new Size(5, 20);
            bullet.BackgroundImage = Properties.Resources.bullet;
            bullet.BackgroundImageLayout = ImageLayout.Stretch;
            bullet.Name = "Bullet";
            this.Controls.Add(bullet);
        }

        private void CheckForWinner()
        {
            int count = 0;

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Alien") count++;
            }

            if (count == 0) YouWon();
        }

        private void YouWon()
        {
            game = false;

            TimerLvl2 ready = new TimerLvl2();
            ready.Show();
            this.Close();
        }

        private void gameOver()
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop(); timer4.Stop(); timer5.Stop(); Observer.Stop();
            
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }

            ShooterLose sl = new ShooterLose();
            sl.ShowDialog();

            if(sl.ctrlyes == "reset" || sl.ctrlno == "continue")
            {
                this.Close();
            }

            /*foreach (Control c in this.Controls)
            {
                if (c is Label && c.Name == "Finish") 
                {
                    Label lbl = (Label)c;
                    lbl.Text = "Game Over!";
                    game = false;
                }
                else
                {
                    c.Visible = false;
                }
            }*/
        }

        private void EnemyNum(int pts)
        {
            enemynum.Text = enem.ToString();
        }
        private void InsertAliens()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Alien")
                {
                    PictureBox alien = (PictureBox)c;
                    aliens.Add(alien);
                }
            }
        }

        private bool Touched(PictureBox a)
        {
            return a.Location.X <= 0 || a.Location.X >= limit;
        }
        private void SetDirection(PictureBox a)
        {
            int size = a.Height;

            if (Touched(a))
            {
                top = 1; left = 0; cnt++;

                if (cnt == size)
                {
                    top = 0; left = speed * (-1); Observer.Start();
                }
                else if (cnt == size * 2)
                {
                    top = 0; left = speed; cnt = 0; Observer.Start();
                }
            }
        }

        private void Observe(object sender, EventArgs e)
        {

        }

        private void AlienMove()
        {
            foreach (PictureBox alien in aliens)
            {
                alien.Location = new Point(alien.Location.X + left, alien.Location.Y + top);
                SetDirection(alien);
                Collided(alien);
            }
        }
        private void Collided(PictureBox a)
        {
            if (a.Bounds.IntersectsWith(Player.Bounds))
            {
                gameOver();
            }
        }

        private void MoveAliens(object sender, EventArgs e)
        {
            AlienMove();
        }
        private void Beam(PictureBox a)
        {
            PictureBox laser = new PictureBox();
            laser.Location = new Point(a.Location.X + a.Width / 3, a.Location.Y + 20);
            laser.Size = new Size(5, 20);
            laser.BackgroundImage = Properties.Resources.laser;
            laser.BackgroundImageLayout = ImageLayout.Stretch;
            laser.Name = "Laser";
            this.Controls.Add(laser);
        }

        private void StrikeSpan(object sender, EventArgs e)
        {
            Random r = new Random();
            int pick;

            if (aliens.Count > 0)
            {
                pick = r.Next(aliens.Count);
                Beam(aliens[pick]);
            }
        }

        private void DetectLaser(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Laser")
                {
                    PictureBox laser = (PictureBox)c;
                    laser.Top += 5;

                    if (laser.Location.Y >= limit)
                    {
                        this.Controls.Remove(laser);
                    }
                    if (laser.Bounds.IntersectsWith(Player.Bounds))
                    {
                        this.Controls.Remove(laser);
                        LoseLife();
                    }
                }
            }
        }

     
        private void LoseLife()
        {
            Player.Location = new Point(x, y);

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name.Contains("Life") && c.Visible == true)
                {
                    PictureBox player = (PictureBox)c;
                    player.Visible = false;
                    return;
                }
            }
            gameOver();
        }

    }
}
