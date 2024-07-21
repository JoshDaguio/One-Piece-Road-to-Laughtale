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
    public partial class LorePt1 : Form
    {
        public LorePt1()
        {
            InitializeComponent();
        }

        private void LorePt1_Load(object sender, EventArgs e)
        {
            next2.Enabled = false;
            next2.Hide();
            next3.Enabled = false;
            next3.Hide();
        }

        private void next1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backstory_pt_2;

            next1.Enabled = false;
            next1.Hide();

            next2.Enabled = true;
            next2.Show();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Backstory_pt_3;

            next2.Enabled = false;
            next2.Hide();

            next3.Enabled = true;
            next3.Show();
        }

        private void next3_Click(object sender, EventArgs e)
        {
            GetName gn = new GetName();
            gn.Show();
            this.Hide();
        }

        //Skip
        private void lore1skip_Click(object sender, EventArgs e)
        {
            GetName gn = new GetName();
            gn.Show();
            this.Hide();
        }

        //Exit
        private void lore1exit_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        //Exit Hover 
        private void lore1exit_MouseEnter(object sender, EventArgs e)
        {
            lore1exit.Image = Properties.Resources.ExitBTNh;
        }
        private void lore1exit_MouseLeave(object sender, EventArgs e)
        {
            lore1exit.Image = Properties.Resources.ExitBTN;
        }

        //Skip Hover
        private void lore1skip_MouseEnter(object sender, EventArgs e)
        {
            lore1skip.Image = Properties.Resources.SkipBTNh;
        }
        private void lore1skip_MouseLeave(object sender, EventArgs e)
        {
            lore1skip.Image = Properties.Resources.SkipBTN;
        }

        //Mouse Enter Next Hover

        private void next_mouseEnter(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is Button && c.Name.Contains("next"))
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
