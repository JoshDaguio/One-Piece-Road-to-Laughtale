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
    public partial class LorePt2 : Form
    {
        public LorePt2()
        {
            InitializeComponent();
        }

        private void LorePt2_Load(object sender, EventArgs e)
        {
            next2.Enabled = false;
            next2.Hide();

            next3.Enabled = false;
            next3.Hide();

            next4.Enabled = false;
            next4.Hide();

            next5.Enabled = false;
            next5.Hide();
        }

        private void next1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore2_pt2;

            next1.Enabled = false;
            next1.Hide();

            next2.Enabled = true;
            next2.Show();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore2_pt3;

            next2.Enabled = false;
            next2.Hide();

            next3.Enabled = true;
            next3.Show();
        }
        private void next3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LorePuzzle1;

            next3.Enabled = false;
            next3.Hide();

            next4.Enabled = true;
            next4.Show();
        }
        private void next4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LorePuzzle2;

            next4.Enabled = false;
            next4.Hide();

            next5.Enabled = true;
            next5.Show();
        }
        private void next5_Click(object sender, EventArgs e)
        {
            PuzzleRulesF pl2 = new PuzzleRulesF();
            pl2.Show();
            this.Hide();
        }
        private void skplore2_Click(object sender, EventArgs e)
        {
            PuzzleRulesF pl2 = new PuzzleRulesF();
            pl2.Show();
            this.Hide();
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

        private void skplore2_MouseEnter(object sender, EventArgs e)
        {
            skplore2.Image = Properties.Resources.SkipBTNh;
        }

        private void skplore2_MouseLeave(object sender, EventArgs e)
        {
            skplore2.Image = Properties.Resources.SkipBTN;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ExitBTNh;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ExitBTN;
        }

        //Mouse Enter Next Hover
        private void next_mouseEnter(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.Contains("next"))
                {
                    Button b = (Button)c;
                    b.Image = Properties.Resources.NextBTNh;
                }
            }
        }
        //Mouse Leave Next Hover
        private void next_mouseLeave(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.Contains("next"))
                {
                    Button b = (Button)c;
                    b.Image = Properties.Resources.NextBTN;
                }
            }
        }

    }
}
