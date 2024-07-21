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
    public partial class ExitMsgBox : Form
    {
        public ExitMsgBox()
        {
            InitializeComponent();
        }

        public string ctrl;

        public void yep_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            ctrl = "ctrl";
        }

        public void nope_Click(object sender, EventArgs e)
        {
            this.Close();
            ctrl = "ctr";
            
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
