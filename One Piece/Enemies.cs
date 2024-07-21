using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Piece
{
    class Enemies
    {
        private int width, height;
        private int columns, rows;
        private int x, y, space;

        public Enemies()
        {
            width = 40;
            height = 40;
            columns = 10;
            rows = 5;
            space = 10;
            x = 150;
            y = 0;
        }

        //Level One Enemies
        private void CreateControl(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(x, y);
            pb.Size = new Size(width, height);
            pb.Image = Properties.Resources.pirate_r;
            //pb.BackgroundImage = Properties.Resources.pirate_r;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.BackColor = ColorTranslator.FromHtml("#363C18");
            pb.Name = "Alien";
            p.Controls.Add(pb);
        }

        public void CreateSprites(Form p)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    CreateControl(p);
                    x += width + space;
                }
                y += height + space;
                x = 150;
            }
        }

        //Level Two Enemies
        private void CreateControl2(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(x, y);
            pb.Size = new Size(width, height);
            pb.Image = Properties.Resources.pirate2_r;
            pb.BackColor = ColorTranslator.FromHtml("#254D4B");
            //pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien";
            p.Controls.Add(pb);
        }
        public void CreateSprites2(Form p)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    CreateControl2(p);
                    x += width + space;
                }
                y += height + space;
                x = 150;
            }
        }

        //Level Three Enemies
        private void CreateControl3(Form p)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(x, y);
            pb.Size = new Size(width, height);
            pb.Image = Properties.Resources.pirate3_r;
            pb.BackColor = ColorTranslator.FromHtml("#572315");
            //pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Name = "Alien";
            p.Controls.Add(pb);
        }
        public void CreateSprites3(Form p)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    CreateControl3(p);
                    x += width + space;
                }
                y += height + space;
                x = 150;
            }
        }


    }
}
