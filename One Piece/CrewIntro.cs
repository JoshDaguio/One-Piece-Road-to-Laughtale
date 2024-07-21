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
    public partial class CrewIntro : Form
    {
        public CrewIntro()
        {
            InitializeComponent();
        }
        private void CrewIntro_Load(object sender, EventArgs e)
        {
            nxt2.Enabled = false;
            nxt2.Hide();
            nxt3.Enabled = false;
            nxt3.Hide();
        }
        
        private void nxt1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.First_Sailing_Lore_introduce_pt_2;

            nxt1.Enabled = false;
            nxt1.Hide();

            nxt2.Enabled = true;
            nxt2.Show();
        }

        private void nxt2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.First_Sailing_Lore_introduce_pt_3;

            nxt2.Enabled = false;
            nxt2.Hide();

            nxt3.Enabled = true;
            nxt3.Show();
        }

        private void nxt3_Click(object sender, EventArgs e)
        {
            LorePt2 l2 = new LorePt2();
            l2.Show();
            this.Hide();
        }

        private void extcrew_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        private void skipcrew_MouseEnter(object sender, EventArgs e)
        {
            skipcrew.Image = Properties.Resources.SkipBTNh;
        }

        private void skipcrew_MouseLeave(object sender, EventArgs e)
        {
            skipcrew.Image = Properties.Resources.SkipBTN;
        }

        private void extcrew_MouseEnter(object sender, EventArgs e)
        {
            extcrew.Image = Properties.Resources.ExitBTNh;
        }

        private void extcrew_MouseLeave(object sender, EventArgs e)
        {
            extcrew.Image = Properties.Resources.ExitBTN;
        }


        //Mouse Enter Next Hover
        private void Next_mouseEnter(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.Contains("nxt"))
                {
                    Button b = (Button)c;
                    b.Image = Properties.Resources.NextBTNh;
                }
            }
        }
        //Mouse Leave Next Hover
        private void Next_mouseLeave(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Name.Contains("nxt"))
                {
                    Button b = (Button)c;
                    b.Image = Properties.Resources.NextBTN;
                }
            }
        }

        private void skipcrew_Click(object sender, EventArgs e)
        {
            LorePt2 l2 = new LorePt2();
            l2.Show();
            this.Hide();
        }
    }
}
