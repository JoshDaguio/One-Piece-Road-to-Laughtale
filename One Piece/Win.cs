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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        FinalDialogBox fdb = new FinalDialogBox();


        private void menu_Click(object sender, EventArgs e)
        {
            fdb.ShowDialog();

            if (fdb.ctrlyes == "yes")
            {
                Start start = new Start();
                start.Show();
                this.Close();
            }
        }

        private void ext_Click(object sender, EventArgs e)
        {
            fdb.ShowDialog();

            if (fdb.ctrlyes == "yes")
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void ext_MouseEnter(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.exitFH;
        }

        private void ext_MouseLeave(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.exitF;
        }

        public void menu_MouseEnter(object sender, EventArgs e)
        {
            menu.Image = Properties.Resources.MenuFH;
        }

        public void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = Properties.Resources.menuF;
        }
    }
}
