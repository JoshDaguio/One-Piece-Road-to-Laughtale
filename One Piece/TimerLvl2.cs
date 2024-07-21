using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    public partial class TimerLvl2 : Form
    {
        public TimerLvl2()
        {
            InitializeComponent();
        }

        int seconds = 0;
        private void TimerLvl2_Load(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader("name.txt");

            Playername.Text = reader.ReadLine() + "?";
            reader.Close();

            seconds = 9;
            countdowntmr.Start();
        }

        private void countdowntmr_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds < 0)
            {
                countdowntmr.Stop();
                ShooterLvlTwo sht = new ShooterLvlTwo();
                sht.Show();
                this.Close();
            }
        }
    }
}
