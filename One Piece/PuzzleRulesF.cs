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
    public partial class PuzzleRulesF : Form
    {
        public PuzzleRulesF()
        {
            InitializeComponent();
        }

        private void PRnext_Click(object sender, EventArgs e)
        {
            Map mapgame = new Map();
            mapgame.Show();
            this.Hide();
        }

  
        private void PRexit_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

  
        private void PRnext_MouseEnter(object sender, EventArgs e)
        {
            PRnext.Image = Properties.Resources.NextBTNh;
        }

        private void PRnext_MouseLeave(object sender, EventArgs e)
        {
            PRnext.Image = Properties.Resources.NextBTN;
        }

        private void PRexit_MouseEnter(object sender, EventArgs e)
        {
            PRexit.Image = Properties.Resources.ExitBTNh;
        }

        private void PRexit_MouseLeave(object sender, EventArgs e)
        {
            PRexit.Image = Properties.Resources.ExitBTN;
        }
    }
}
