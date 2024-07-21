using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace One_Piece
{
    public partial class LorePt4 : Form
    {
        public LorePt4()
        {
            InitializeComponent();
        }

        private void LorePt4_Load(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader("name.txt");

            Playername.Text = reader.ReadLine() + "!";
            reader.Close();

            Playername.Location = new Point(313, 518);

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
            this.BackgroundImage = Properties.Resources.Lore4_pt1;

            Playername.Hide();

            next1.Enabled = false;
            next1.Hide();

            next2.Enabled = true;
            next2.Show();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore4_pt2;

            next2.Enabled = false;
            next2.Hide();

            next3.Enabled = true;
            next3.Show();
        }

        private void next3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Lore4_pt3;

            Playername.Show();
            Playername.Location = new Point(177, 185);

            next3.Enabled = false;
            next3.Hide();

            next4.Enabled = true;
            next4.Show();
        }

        private void next4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LoreShtr_pt1;

            Playername.Hide();

            next4.Enabled = false;
            next4.Hide();

            next5.Enabled = true;
            next5.Show();
        }
        private void next5_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LoreShtr_pt2;

            next5.Enabled = false;
            next5.Hide();

            next6.Enabled = true;
            next6.Show();
        }

        private void next6_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LoreShtr_pt3;

            Playername.Show();
            Playername.Location = new Point(154, 602);

            next6.Enabled = false;
            next6.Hide();

            next7.Enabled = true;
            next7.Show();
        }

        private void next7_Click(object sender, EventArgs e)
        {
            ShtrRules sr = new ShtrRules();
            sr.Show();
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
        private void skip_Click(object sender, EventArgs e)
        {
            ShtrRules sr = new ShtrRules();
            sr.Show();
            this.Close();
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
