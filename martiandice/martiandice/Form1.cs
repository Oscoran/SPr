using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martiandice
{
    public partial class Form1 : Form
    {
        List<PictureBox> pblist = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 100;
            for (int i = 0; i < 13; i++)
            {
                PictureBox pictureBox = new PictureBox();
                this.Controls.Add(pictureBox);
                pictureBox.Image = Properties.Resources.tank;
                pictureBox.Size = new Size(70, 70);
                pictureBox.Location = new Point(x, 25);
                x+= 80;
                pictureBox.SizeMode= PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pictureBox);
                pblist.Add(pictureBox);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            int[] dieceroll = dice.roll(13);
            int position= 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j   = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0:
                            pblist[position].Image = Properties.Resources.tank;
                            break;
                    }
                }
            }
            
        }
    }
}
