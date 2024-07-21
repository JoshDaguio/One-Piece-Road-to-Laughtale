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
    public partial class ExitGame : Form
    {
        public ExitGame()
        {
            InitializeComponent();
        }

        public string ctrl;


        private void nope_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yep_Click(object sender, EventArgs e)
        {
            ctrl = "yes";

            this.Close();
            Start menu = new Start();
            menu.Show();
        }

        //Exiting Class To Acces This Dialog Box
        public void ExitInGame()
        {
            ExitGame eg = new ExitGame();
            Start menu = new Start();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
                menu.Show();
            }
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
