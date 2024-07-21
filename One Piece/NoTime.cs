using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    public partial class NoTime : Form
    {
        public NoTime()
        {
            InitializeComponent();
        }
        public string ctrlyes, ctrlno, ctrlretire, ctrlrestart;


        private void retire()
        {
            Retire r = new Retire();
            r.ShowDialog();

            if (r.ctrlyes == "retire")
            {
                ctrlretire = "retire";
            }
            if (r.ctrlrestart == "restart")
            {
                ctrlrestart = "restart";
            }
        }
        private void yep_Click(object sender, EventArgs e)
        {
            this.Close();

            ctrlyes = "yes";
        }

        private void nope_Click(object sender, EventArgs e)
        {
            this.Close();

            ctrlno = "no";
            retire();
        }

        private void yep_MouseEnter(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.yesEBH;
        }

        private void yep_MouseLeave(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.yesEB;
        }

        private void nope_MouseEnter(object sender, EventArgs e)
        {
            nope.Image = Properties.Resources.noEBH;
        }

        private void nope_MouseLeave(object sender, EventArgs e)
        {
            nope.Image = Properties.Resources.noEB;
        }
    }
}
