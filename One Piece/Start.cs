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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        //Start Button
        private void strt_Click(object sender, EventArgs e)
        {
            LorePt1 p1 = new LorePt1();
            p1.Show();
            this.Hide();
        }

        //Exit
        private void ext_Click(object sender, EventArgs e)
        {
            ExitMsgBox eb = new ExitMsgBox();
            eb.ShowDialog();
        }

        //About
        private void abt_Click(object sender, EventArgs e)
        {
            this.Hide();

            About abt = new About();
            abt.Show();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitMsgBox eb = new ExitMsgBox();
            eb.ShowDialog();

            if(eb.ctrl == "ctr")
            {
                e.Cancel = true;
            }
        }

        //Start button hovered
        private void strt_MouseEnter(object sender, EventArgs e)
        {
            strt.Image = Properties.Resources.StrtBtnH;
        }

        private void strt_MouseLeave(object sender, EventArgs e)
        {
            strt.Image = Properties.Resources.StrtBtn;
        }

        private void ext_MouseEnter(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.ExtBtnH;
        }

        private void ext_MouseLeave(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.ExtBtn;
        }

        private void abt_MouseEnter(object sender, EventArgs e)
        {
            abt.Image = Properties.Resources.AbtBtnH;
        }

        private void abt_MouseLeave(object sender, EventArgs e)
        {
            abt.Image = Properties.Resources.AbtBtn;
        }
    }
}
