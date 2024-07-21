using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace One_Piece
{
    public partial class Map : Form
    {

        public Map()
        {
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;
            InitializeComponent();
        }
        Point EmptyPoint;
        ArrayList images = new ArrayList();
        int seconds = 0;
        int fastest = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            button10.Hide();
            button10.Enabled = false;
            button11.Hide();
            button11.Enabled = false;
            button12.Hide();
            button12.Enabled = false;

            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();

            TextReader tr = new StreamReader("FastestMap.txt");
            FastestTime.Text= tr.ReadLine();
            tr.Close();
        }

        //Start
        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Button b in panel1.Controls)
                b.Enabled = true;

            Image orginal = Properties.Resources.map_orig;

            cropImageTomages(orginal, 270, 270);

            AddImagesToButtons(images);
            button9.Enabled = false;
            button10.Show();
            button10.Enabled = true;
            button11.Show();
            button11.Enabled = true;
            button12.Show();
            button12.Enabled = true;

            button9.Enabled = false;
            button9.Hide();

            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();

            cntTimer();
        }

        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };

            arr = suffle(arr);

            foreach (Button b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }
        //Shuffle
        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Image orginal = Properties.Resources.map_orig;

            cropImageTomages(orginal, 270, 270);

            AddImagesToButtons(images);
        }


        private void cropImageTomages(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);

            Graphics graphic = Graphics.FromImage(bmp);

            graphic.DrawImage(orginal, 0, 0, w, h);

            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);

                movr += 90;

                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }

        }
        //Move puzzle pieces
        private void button1_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void MoveButton(Button btn)
        {
            if (((btn.Location.X == EmptyPoint.X - 90 || btn.Location.X == EmptyPoint.X + 90)
                && btn.Location.Y == EmptyPoint.Y)
                || (btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90)
                && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
                CheckValid();
        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
            {

                CountDownTimer.Stop();
                NewHighScore();
                Win();                
            }
        }

        private void NewHighScore()
        {
            if(fastest < Convert.ToInt32(FastestTime.Text))
            {
                TextWriter tw = new StreamWriter("FastestMap.txt");
                tw.WriteLine(fastest);
                tw.Close();
            }
        }
        
        private void Win()
        {
            WinMiniG wg = new WinMiniG();
            LorePt3 l3 = new LorePt3();

            wg.ShowDialog();
            if (wg.ctrcontinue == "continue")
            {
                this.Close();
                l3.Show();
            }
        }

        //Ran Out Of Time
        private void RanOutOfTime()
        {
            Map restart = new Map();
            NoTime nt = new NoTime();

            nt.ShowDialog();
            

            if (nt.ctrlretire == "retire")
            {
                this.Close();
            }
            if(nt.ctrlrestart == "restart" || nt.ctrlyes == "yes")
            {
                this.Close();
                restart.Show();
            }
        }

        private void cntTimer()
        {
            timer.Text = "300";
            seconds = 299;
            CountDownTimer.Start();
        }

        //Show Map
        private void button11_Click(object sender, EventArgs e)
        {
            ShowMap sm = new ShowMap();
            sm.Show();
        }

        //Restart
        private void button12_Click(object sender, EventArgs e)
        {
            Map restart = new Map();
            restart.Show();
            this.Close();
        }

        //Exit
        private void button13_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            timer.Text = seconds--.ToString();
            fastest++;
            if (seconds < 0)
            {
                CountDownTimer.Stop();

                RanOutOfTime();
            }

        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.Image = Properties.Resources.RestartBTNmh;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.Image = Properties.Resources.RestartBTNm;
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.Image = Properties.Resources.ShuffleBTNhm;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.Image = Properties.Resources.ShufflBTNm;
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.Image = Properties.Resources.VmapBTNhm;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.Image = Properties.Resources.VmapBTNm;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.Image = Properties.Resources.StartBTNhm;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.Image = Properties.Resources.StartBTNm;
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button13.Image = Properties.Resources.ExitBTNhm;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.Image = Properties.Resources.ExitBTNm;
        }

    }
}
