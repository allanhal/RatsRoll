using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatsRoll
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public static Bitmap RotateImage(Image image, PointF offset, float angle)
        //{
        //    if (image == null)
        //        throw new ArgumentNullException("image");

        //    //create a new empty bitmap to hold rotated image
        //    Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
        //    rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        //    //make a graphics object from the empty bitmap
        //    Graphics g = Graphics.FromImage(rotatedBmp);

        //    //Put the rotation point in the center of the image
        //    g.TranslateTransform(offset.X, offset.Y);

        //    //rotate the image
        //    g.RotateTransform(angle);

        //    //move the image back
        //    g.TranslateTransform(-offset.X, -offset.Y);

        //    //draw passed in image onto graphics object
        //    g.DrawImage(image, new PointF(0, 0));

        //    return rotatedBmp;
        //}
        
       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_com.Text != "")
                {
                    Corrida c1 = new Corrida(cb_com.Text, txt_rato_1.Text, txt_rato_2.Text);
                    c1.Show();
                }
                else
                {
                    MessageBox.Show("COLOCA A PORTA COM PORRA!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("DEU ERRO NESTA MERDA!\n"+ex.Message);
            }
        }
              

    }
}
