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
        int[] dieceroll;
        int[] result=new int[5];
        int[] countufo = new int[14];
        int actual = 0;
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
                x += 80;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Click += pictureBox1_Click;
                this.Controls.Add(pictureBox);
                pblist.Add(pictureBox);
                
                
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Dice dice = new Dice();
            dieceroll = dice.roll(13);
            for (int j = 0; j < result.Length; j++)
            {
                result[j] = 0;
            }
            int position= 0;
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < dieceroll[i]; j++)
                {
                    switch (i)
                    {
                        case 0:
                            pblist[position].Image = Properties.Resources.tank;
                            result[0]++;
                            
                            break;
                        case 1:
                            pblist[position].Image = Properties.Resources.hen;
                            result[1]++;
                            break;
                        case 2:
                            pblist[position].Image = Properties.Resources.human;
                            result[2]++;
                            break;
                        case 3:
                            pblist[position].Image = Properties.Resources.cow;
                            result[3]++;
                            break;
                        case 4:
                            pblist[position].Image = Properties.Resources.ufo;
                            result[4]++;
                            break;
                        default:
                            break;
                        
                    }
                    position++;

                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = (sender as PictureBox).Location.X;
            int pozition = x/80;
            for (int i = 0; i < result.Length; i++)
            {
                if (pozition <= result[i])
                {
                    MessageBox.Show(i.ToString());
                    break;
                }
                else
                {
                   pozition= pozition - result[i];
                }
            }
            
        }
    }
}
