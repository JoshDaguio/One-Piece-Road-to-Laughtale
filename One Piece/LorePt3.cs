using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    public partial class LorePt3 : Form
    {
        public LorePt3()
        {
            InitializeComponent();
        }

        private void LorePt3_Load(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader("name.txt");

            Playername.Text = reader.ReadLine() + ".";
            reader.Close();

            Playername.Hide();

            next2.Enabled = false;
            next3.Enabled = false;
            next4.Enabled = false;
            next5.Enabled = false;
            next6.Enabled = false;
            next7.Enabled = false;

            next2.Hide();
            next3.Hide();
            next4.Hide();
            next5.Hide();
            next6.Hide();
            next7.Hide();
        }

        private void next1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore3_pt2;

            next1.Enabled = false;
            next1.Hide();

            next2.Enabled = true;
            next2.Show();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore3_pt3;

            next2.Enabled = false;
            next2.Hide();

            next3.Enabled = true;
            next3.Show();
        }

        private void next3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore3_pt4;

            next3.Enabled = false;
            next3.Hide();

            next4.Enabled = true;
            next4.Show();
        }

        private void next4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore3_pt5;

            next4.Enabled = false;
            next4.Hide();

            next5.Enabled = true;
            next5.Show();
        }

        private void next5_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore3_pt6;

            next5.Enabled = false;
            next5.Hide();

            next6.Enabled = true;
            next6.Show();
        }
        private void next6_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LorePone2;

            Playername.Show();

            next6.Enabled = false;
            next6.Hide();

            next7.Enabled = true;
            next7.Show();
        }

        private void next7_Click(object sender, EventArgs e)
        {
            RulesPone rp = new RulesPone();
            rp.Show();
            this.Close();
        }

        private void skip_Click(object sender, EventArgs e)
        {
            RulesPone pl = new RulesPone();
            pl.Show();
            this.Close();
        }

        private void ext_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        private void skip_MouseEnter(object sender, EventArgs e)
        {
            skip.Image = Properties.Resources.SkipBTNh;
        }

        private void skip_MouseLeave(object sender, EventArgs e)
        {
            skip.Image = Properties.Resources.SkipBTN;
        }

        private void ext_MouseEnter(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.ExitBTNh; 
        }

        private void ext_MouseLeave(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.ExitBTN;
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
