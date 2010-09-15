using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
//zmiana
namespace mapka
{
    public partial class Form1 : Form
    {
        //test repo bo coś nawala
        List<Point> moja_lista_punktow;
     
        Graphics test;

        Pen pioro;
        float skala = 1.0f;///?
        public Form1()
        {
            InitializeComponent();
            moja_lista_punktow = new List<Point>();
           
            test = pictureBox1.CreateGraphics();
            pioro = new Pen(Brushes.Red);
        }
        private void odswiez()
        {
            
            float szer = 4 / skala;
            pioro.Width = szer;
            foreach (Point punkt in moja_lista_punktow)
            {
                test.DrawLine(
                pioro,
                new Point(punkt.X - (int)szer, punkt.Y - (int)szer),
                new Point(punkt.X + (int)szer, punkt.Y + (int)szer)
                );
                test.DrawLine(
                    pioro,
                    new Point(punkt.X + (int)szer, punkt.Y - (int)szer),
                    new Point(punkt.X - (int)szer, punkt.Y + (int)szer)
                    );
                
           }
            pictureBox1.Update();
           


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
          
        }
         
        private void mouseDown(object sender, MouseEventArgs e)
        {  
            pioro.Width = 4/skala;//?
            if(checkBox1.Checked==false)
            moja_lista_punktow.Add(new Point((int)(e.Location.X/skala), (int)(e.Location.Y/skala)));

            
            odswiez();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            odswiez();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Width = Form1.ActiveForm.Width - 30;
            panel1.Height = Form1.ActiveForm.Height - 75;
            odswiez();
        }

        private void przySkrolnieciu(object sender, ScrollEventArgs e)
        {
            odswiez();
        }

        private void rysowanie(object sender, PaintEventArgs e)
        {
            odswiez();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (skala < 4)
            {
                /*poniższym, z odpowiednim argumentem, powinno się
                 * dać zescrollować do odpowiedniego obszaru,
                 * naczy centrum obrazka
                 * A tak w ogóle, to przerobić to i poniższe na
                 * jakąś funkcję
                 */
                //    panel1.SetAutoScrollMargin(); 
                pictureBox1.Scale(new System.Drawing.SizeF(2, 2));
                test.ScaleTransform(2, 2);//?
                skala *= 2.0f;///?
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox1.Refresh();
                odswiez();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*poniższym, z odpowiednim argumentem, powinno się
             * dać zescrollować do odpowiedniego obszaru,
             * naczy centrum obrazka
             * A tak w ogóle, to przerobić to i powyższe na jakąś 
             * funkcję
             */
            //    panel1.SetAutoScrollMargin(); 
            if (skala > 0.0625)
            {
                panel1.ScrollControlIntoView(pictureBox1);
                pictureBox1.Scale(new System.Drawing.SizeF(0.5f, 0.5f));
                test.ScaleTransform(0.5f, 0.5f);//?
                skala *= 0.5f;///?
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
                odswiez();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            odswiez();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            odswiez();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            odswiez();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
