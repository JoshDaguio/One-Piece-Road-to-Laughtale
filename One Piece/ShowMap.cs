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
    public partial class ShowMap : Form
    {
        public ShowMap()
        {
            InitializeComponent();
        }

        private void ShowMap_Load(object sender, EventArgs e)
        {
            TextReader tr = new StreamReader("FastestMap.txt");
            ft.Text = tr.ReadLine();
            tr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.ResumeMH;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.ResumeM;
        }

   
    }
}
