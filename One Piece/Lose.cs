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
    public partial class Lose : Form
    {
        public Lose()
        {
            InitializeComponent();
        }

        FinalDialogBox fdb = new FinalDialogBox();

        private void menu_Click(object sender, EventArgs e)
        {
            fdb.ShowDialog();

            if (fdb.ctrlyes == "yes")
            {
                Start menu = new Start();
                menu.Show();
                this.Close();
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            fdb.ShowDialog();

            if (fdb.ctrlyes == "yes")
            {
                PuzzleRulesF reset = new PuzzleRulesF();
                reset.Show();
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

        private void menu_MouseEnter(object sender, EventArgs e)
        {
            menu.Image = Properties.Resources.MenuFH;
        }

        private void menu_MouseLeave(object sender, EventArgs e)
        {
            menu.Image = Properties.Resources.menuF;
        }

        private void restart_MouseEnter(object sender, EventArgs e)
        {
            restart.Image = Properties.Resources.restartFH;
        }

        private void restart_MouseLeave(object sender, EventArgs e)
        {
            restart.Image = Properties.Resources.restartF;
        }

        private void ext_MouseEnter(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.exitFH;
        }

        private void ext_MouseLeave(object sender, EventArgs e)
        {
            ext.Image = Properties.Resources.exitF;
        }
    }
}
