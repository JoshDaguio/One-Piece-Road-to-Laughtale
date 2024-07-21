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
    public partial class Retire : Form
    {
        public Retire()
        {
            InitializeComponent();
        }

        public string ctrlyes, ctrlrestart;

        private void restart_Click(object sender, EventArgs e)
        {
            this.Close();

            ctrlrestart = "restart";
        }

        private void yep_Click(object sender, EventArgs e)
        {
            this.Close();

            ctrlyes = "retire";

            Start menu = new Start();
            menu.Show();
        }

        private void yep_MouseEnter(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.yesEBH;
        }

        private void yep_MouseLeave(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.yesEB;
        }

        private void restart_MouseEnter(object sender, EventArgs e)
        {
            restart.Image = Properties.Resources.restartMBH;
        }

        private void restart_MouseLeave(object sender, EventArgs e)
        {
            restart.Image = Properties.Resources.restartMB;
        }

    }
}
