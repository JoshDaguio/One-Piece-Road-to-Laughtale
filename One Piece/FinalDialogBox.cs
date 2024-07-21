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
    public partial class FinalDialogBox : Form
    {
        public FinalDialogBox()
        {
            InitializeComponent();
        }

        public string ctrlyes, ctrlno;

        private void yep_Click(object sender, EventArgs e)
        {
            this.Close();
            ctrlyes = "yes";
        }

        private void nope_Click(object sender, EventArgs e)
        {
            this.Close();
            ctrlno = "no";
        }

        private void yep_MouseEnter(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.YesRH;
        }

        private void yep_MouseLeave(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.YesR;
        }

        private void nope_MouseEnter(object sender, EventArgs e)
        {
            nope.Image = Properties.Resources.NoRH;
        }

        private void nope_MouseLeave(object sender, EventArgs e)
        {
            nope.Image = Properties.Resources.NoR;
        }
    }
}
