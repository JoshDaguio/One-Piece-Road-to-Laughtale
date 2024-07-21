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
    public partial class TimerLvl3 : Form
    {
        public TimerLvl3()
        {
            InitializeComponent();
        }

        int seconds = 0;

        private void TimerLvl3_Load(object sender, EventArgs e)
        {
            seconds = 9;
            cntdwn.Start();
        }

        private void cntdwn_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds < 0)
            {
                cntdwn.Stop();
                ShooterLvlThree sht = new ShooterLvlThree();
                sht.Show();
                this.Close();
            }
        }
    }
}
