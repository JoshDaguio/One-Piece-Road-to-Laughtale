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
    public partial class JoinCrew : Form
    {
        public JoinCrew()
        {
            InitializeComponent();
        }

        private void JoinCrew_Load(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader("name.txt");

            Playername.Text = reader.ReadLine() + "?";
            reader.Close();
        }

        private void joinc_Click(object sender, EventArgs e)
        {
            CrewIntro ci = new CrewIntro();
            ci.Show();
            this.Hide();
        }

        private void joinc_MouseEnter(object sender, EventArgs e)
        {
            joinc.Image = Properties.Resources.Join_CrewH;
        }

        private void joinc_MouseLeave(object sender, EventArgs e)
        {
            joinc.Image = Properties.Resources.Join_Crew;
        }

        private void refuse_MouseEnter(object sender, EventArgs e)
        {
            refuse.Image = Properties.Resources.RefuseJCH;
        }

        private void refuse_MouseLeave(object sender, EventArgs e)
        {
            refuse.Image = Properties.Resources.RefuseJC;
        }

        private void refuse_Click(object sender, EventArgs e)
        {
            ExitGame eg = new ExitGame();
            eg.ShowDialog();

            if (eg.ctrl == "yes")
            {
                this.Close();
            }
        }
    }
}
