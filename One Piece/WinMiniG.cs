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
    public partial class WinMiniG : Form
    {
        public WinMiniG()
        {
            InitializeComponent();
        }

        public string ctrcontinue;

        private void yep_Click(object sender, EventArgs e)
        {
            this.Close();
            ctrcontinue = "continue";

            //LorePt3 l3 = new LorePt3();
            //l3.Show();
        }

        private void yep_MouseEnter(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.cntMBH;
        }

        private void yep_MouseLeave(object sender, EventArgs e)
        {
            yep.Image = Properties.Resources.cntMB;
        }
      
    }
}
