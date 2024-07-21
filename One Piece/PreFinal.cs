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
    public partial class PreFinal : Form
    {
        public PreFinal()
        {
            InitializeComponent();
        }
        int seconds = 0;
        private void countdown_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 7)
            {
                countdown.Stop();
                ShooterLvlOne shtlvl1 = new ShooterLvlOne();
                shtlvl1.Show();
                this.Close();
            }
        }
        private void PreFinal_Load(object sender, EventArgs e)
        {
            countdown.Start();
        }
    }
}
