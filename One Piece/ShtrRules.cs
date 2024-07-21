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
    public partial class ShtrRules : Form
    {
        public ShtrRules()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreFinal shtr1 = new PreFinal();
            shtr1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.NextBTNh;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.NextBTN;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ExitBTNh;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ExitBTN;
        }
    }
}
