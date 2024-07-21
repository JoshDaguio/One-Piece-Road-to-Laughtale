using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    public partial class Poneglyph : Form
    {
        public Poneglyph()
        {
            InitializeComponent();
            assignPos();
            print2d(symbols);
        }

        bool state = true;
        int seconds = 0;
        int fseconds = 0;
        int itemsleft = 0;
        int fastest = 0;

        bool enable_button1 = true;
        bool enable_button2 = true; 
        bool enable_button3 = true; 
        bool enable_button4 = true; 
        bool enable_button5 = true;
        bool enable_button6 = true; 
        bool enable_button7 = true; 
        bool enable_button8 = true; 
        bool enable_button9 = true; 
        bool enable_button10 = true;
        bool enable_button11 = true; 
        bool enable_button12 = true; 
        bool enable_button13 = true; 
        bool enable_button14 = true; 
        bool enable_button15 = true; 
        bool enable_button16 = true;

        int score = 0;

        Random rand = new Random();
        int[,] symbols = new int[4, 4];


        void assignPos()
        {
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    symbols[a, b] = 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                int x = rand.Next(4);
                int y = rand.Next(4);

                if (symbols[x, y] == 1)
                    while (symbols[x, y] == 1)
                    {
                        x = rand.Next(1, 4);
                        y = rand.Next(1, 4);
                    }
                symbols[x, y] = 1;
            }
        }


        //Buttons Click to assign Value
        void clicked(int x, int y, Button button)
        {
            if (symbols[x, y] == 0)
            {
                state = !state;
                button.Image = Properties.Resources.bomb_r;

                CountDown.Stop();

                Lost();
            }
            else
            {
                button.Image = Properties.Resources.map_r;

                score += 2;

                items.Text = itemsleft--.ToString();
            }
            if (score > 7)
            {
                state = !state;
                CountDown.Stop();
                NewHighScore();
                Win();
            }
        }

        public static void print2d(int[,] arr)
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        //Win
        private void Win()
        {
            WinMiniG wg = new WinMiniG();
            LorePt4 l4 = new LorePt4();

            wg.ShowDialog();
            if (wg.ctrcontinue == "continue")
            {
                this.Close();
                l4.Show();
            }
        }

        //Timer Ran out
        private void RunOutOfTime()
        {
            Poneglyph restart = new Poneglyph();
            NoTime nt = new NoTime();

            nt.ShowDialog();


            if (nt.ctrlretire == "retire")
            {
                this.Close();
            }
            if (nt.ctrlrestart == "restart" || nt.ctrlyes == "yes")
            {
                this.Close();
                restart.Show();

            }
        }

        //Got A Bomb
        private void Lost()
        {
            Poneglyph restart = new Poneglyph();
            Caught c = new Caught();

            c.ShowDialog();


            if (c.ctrlretire == "retire")
            {
                this.Close();
            }
            if (c.ctrlrestart == "restart" || c.ctrlyes == "yes")
            {
                this.Close();
                restart.Show();
            }
        }

        //Restart
        private void button17_Click(object sender, EventArgs e)
        {
            restartGame();
        }
        void restartGame()
        {
            Poneglyph pone = new Poneglyph();
            this.Hide();
            pone.Show();
        }

        void cntTimer()
        {
            timer.Text = "300";
            seconds = 299;
            CountDown.Start();
        }

        //Start
        private void button18_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.Enabled = true;
            }
            button18.Enabled = false;
            button18.Hide();
            button17.Enabled = true;
            button17.Show();
            items.Show();
            items.Text = "4";
            itemsleft = 3;

            cntTimer();

            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
        }


        //Form Open
        private void Poneglyph_Load(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.Enabled = !c.Enabled;
            }
            button17.Enabled = false;
            button17.Hide();
            items.Hide();

            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();

            TextReader tr = new StreamReader("FastestPone.txt");
            ft.Text = tr.ReadLine();
            tr.Close();
        }

        //Fastest Time Record
        private void NewHighScore()
        {
            if (fastest < Convert.ToInt32(ft.Text))
            {
                TextWriter tw = new StreamWriter("FastestPone.txt");
                tw.WriteLine(fastest);
                tw.Close();
            }
        }

        //Timer
        private void CountDown_Tick(object sender, EventArgs e)
        {
            timer.Text = seconds--.ToString();
            fastest++;
            if (seconds < 0)
            {
                CountDown.Stop();
                RunOutOfTime();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        //Hover Button Effects
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button1 == true)
            {
                button1.Image = Properties.Resources.ochest_r;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button1 == true)
            {
                button1.Image = Properties.Resources.cchest_r;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button2 == true)
            {
                button2.Image = Properties.Resources.ochest_r;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button2 == true)
            {
                button2.Image = Properties.Resources.cchest_r;
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button3 == true)
            {
                button3.Image = Properties.Resources.ochest_r;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button3 == true)
            {
                button3.Image = Properties.Resources.cchest_r;
            }
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button4 == true)
            {
                button4.Image = Properties.Resources.ochest_r;
            }
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button4 == true)
            {
                button4.Image = Properties.Resources.cchest_r;
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button5 == true)
            {
                button5.Image = Properties.Resources.ochest_r;
            }
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button5 == true)
            {
                button5.Image = Properties.Resources.cchest_r;
            }
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button6 == true)
            {
                button6.Image = Properties.Resources.ochest_r;
            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button6 == true)
            {
                button6.Image = Properties.Resources.cchest_r;
            }
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button7 == true)
            {
                button7.Image = Properties.Resources.ochest_r;
            }
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button7 == true)
            {
                button7.Image = Properties.Resources.cchest_r;
            }
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button8 == true)
            {
                button8.Image = Properties.Resources.ochest_r;
            }
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button8 == true)
            {
                button8.Image = Properties.Resources.cchest_r;
            }
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button9 == true)
            {
                button9.Image = Properties.Resources.ochest_r;
            }
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button9 == true)
            {
                button9.Image = Properties.Resources.cchest_r;
            }
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button10 == true)
            {
                button10.Image = Properties.Resources.ochest_r;
            }
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button10 == true)
            {
                button10.Image = Properties.Resources.cchest_r;
            }
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button11 == true)
            {
                button11.Image = Properties.Resources.ochest_r;
            }
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button11 == true)
            {
                button11.Image = Properties.Resources.cchest_r;
            }
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button12 == true)
            {
                button12.Image = Properties.Resources.ochest_r;
            }
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button12 == true)
            {
                button12.Image = Properties.Resources.cchest_r;
            }
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button13 == true)
            {
                button13.Image = Properties.Resources.ochest_r;
            }
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button13 == true)
            {
                button13.Image = Properties.Resources.cchest_r;
            }
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button14 == true)
            {
                button14.Image = Properties.Resources.ochest_r;
            }
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button14 == true)
            {
                button14.Image = Properties.Resources.cchest_r;
            }
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button15 == true)
            {
                button15.Image = Properties.Resources.ochest_r;
            }
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button15 == true)
            {
                button15.Image = Properties.Resources.cchest_r;
            }
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            if (enable_button16 == true)
            {
                button16.Image = Properties.Resources.ochest_r;
            }
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            if (enable_button16 == true)
            {
                button16.Image = Properties.Resources.cchest_r;
            }
        }

        //Clicked
        private void button1_Click(object sender, EventArgs e)
        {
            if (enable_button1 == true)
            {
                enable_button1 = false;
                clicked(0, 0, button1);

            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (enable_button2 == true)
            {
                enable_button2 = false;
                clicked(0, 1, button2);
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (enable_button3 == true)
            {
                enable_button3 = false;
                clicked(0, 2, button3);
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (enable_button4 == true)
            {
                enable_button4 = false;
                clicked(0, 3, button4);
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (enable_button5 == true)
            {
                enable_button5 = false;
                clicked(1, 0, button5);
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (enable_button6 == true)
            {
                enable_button6 = false;
                clicked(1, 1, button6);
            }
            else
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (enable_button7 == true)
            {
                enable_button7 = false;
                clicked(1, 2, button7);
            }
            else
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (enable_button8 == true)
            {
                enable_button8 = false;
                clicked(1, 3, button8);
            }
            else
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (enable_button9 == true)
            {
                enable_button9 = false;
                clicked(2, 0, button9);
            }
            else
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (enable_button10 == true)
            {
                enable_button10 = false;
                clicked(2, 1, button10);
            }
            else
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (enable_button11 == true)
            {
                enable_button11 = false;
                clicked(2, 2, button11);
            }
            else
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (enable_button12 == true)
            {
                enable_button12 = false;
                clicked(2, 3, button12);
            }
            else
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (enable_button13 == true)
            {
                enable_button13 = false;
                clicked(3, 0, button13);
            }
            else
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (enable_button14 == true)
            {
                enable_button14 = false;
                clicked(3, 1, button14);
            }
            else
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (enable_button15 == true)
            {
                enable_button15 = !enable_button15;
                clicked(3, 2, button15);
            }
            else
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (enable_button16 == true)
            {
                enable_button16 = false;
                clicked(3, 3, button16);
            }
            else
            {

            }
        }


        private void button19_MouseEnter(object sender, EventArgs e)
        {
            button19.Image = Properties.Resources.ExitBTNhm;
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.Image = Properties.Resources.ExitBTNm;
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            button17.Image = Properties.Resources.Restart_1;
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.Image = Properties.Resources.Restart;
        }

        private void button18_MouseEnter(object sender, EventArgs e)
        {
            button18.Image = Properties.Resources.StartBTNhm;
        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            button18.Image = Properties.Resources.StartBTNm;
        }

    }
}
