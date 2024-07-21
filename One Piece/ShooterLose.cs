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
    public partial class ShooterLose : Form
    {
        public ShooterLose()
        {
            InitializeComponent();
        }

        public string ctrlyes, ctrlno;

        private void rst_Click(object sender, EventArgs e)
        {
            this.Close();
            ctrlyes = "reset";

            ShtrRules sr = new ShtrRules();
            sr.Show();
        }

        private void cnt_Click(object sender, EventArgs e)
        {
            this.Close();

            ctrlno = "continue";

            Lose l = new Lose();
            l.Show();
        }

        private void rst_MouseEnter(object sender, EventArgs e)
        {
            rst.Image = Properties.Resources.rstSLH;
        }

        private void rst_MouseLeave(object sender, EventArgs e)
        {
            rst.Image = Properties.Resources.rstSL;
        }

        private void cnt_MouseEnter(object sender, EventArgs e)
        {
            cnt.Image = Properties.Resources.cntSLH;
        }

        private void cnt_MouseLeave(object sender, EventArgs e)
        {
            cnt.Image = Properties.Resources.cntSL;
        }
    }
}
