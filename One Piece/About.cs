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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Start menu = new Start();
            this.Close();
            menu.Show();
        }

        private void back_MouseEnter(object sender, EventArgs e)
        {
            back.Image = Properties.Resources.backAH;
        }

        private void back_MouseLeave(object sender, EventArgs e)
        {
            back.Image = Properties.Resources.backA;
        }
    }
}
