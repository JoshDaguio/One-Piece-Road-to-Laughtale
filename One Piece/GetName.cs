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
    public partial class GetName : Form
    {
        public GetName()
        {
            InitializeComponent();
        }

        private void confirmname_Click(object sender, EventArgs e)
        {
            TextWriter write = new StreamWriter("name.txt");

            write.Write(textBox1.Text);

            write.Close();

            textBox1.Enabled = false;
            confirmname.Enabled = false;
            confirmname.Hide();
        }

        private void resetname_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            confirmname.Enabled = true;
            confirmname.Show();
            textBox1.Clear();
        }

        private void resetname_MouseEnter(object sender, EventArgs e)
        {
            resetname.Image = Properties.Resources.ResetNH;
        }

        private void resetname_MouseLeave(object sender, EventArgs e)
        {
            resetname.Image = Properties.Resources.ResetN;
        }

        private void confirmname_MouseEnter(object sender, EventArgs e)
        {
            confirmname.Image = Properties.Resources.ConfirmNH;
        }

        private void confirmname_MouseLeave(object sender, EventArgs e)
        {
            confirmname.Image = Properties.Resources.ConfirmN;
        }

        private void nxt_MouseEnter(object sender, EventArgs e)
        {
            nxt.Image = Properties.Resources.NextBTNh;
        }
        private void nxt_MouseLeave(object sender, EventArgs e)
        {
            nxt.Image = Properties.Resources.NextBTN;
        }

        //Exit
        private void ext_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }

        private void ext_MouseEnter(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.ExitBTNh;
        }

        private void ext_MouseLeave(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.ExitBTN;
        }

        private void nxt_Click(object sender, EventArgs e)
        {
            JoinCrew jc = new JoinCrew();
            jc.Show();
            this.Hide();
        }

    }
}
