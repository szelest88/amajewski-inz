using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_billboardingu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics test;
        Pen pioro;
        private void Form1_Load(object sender, EventArgs e)
        {
            test = pictureBox1.CreateGraphics();
            Brush pedzel = Brushes.Blue;
            pioro=new Pen(pedzel);
            
           }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tick(object sender, EventArgs e)
        {
           //do luftu chwilowo
            //a może jednak (wystarczyło skorygować kąt o 45)
            //trzeba tylko sprawdzić jeszcze sytuacke, w których któraś
            //współrzędna się zeruje, i zbadać jakoś  położenie nie względem
            //początku ekranu, ale początku formy (może wystarczy dodać do
            //współrzędnych czegośtam współrzędne obracającego się obiektu
            //przy czym w sumie to ostatnie nie jest konieczne (w OpenGL będziemy
            //badać współrzędne innych obiektów
            label1.Text = ", "+MousePosition.X+", "+MousePosition.Y+", "+-(float)Math.Atan((double)((double)MousePosition.Y / (double)MousePosition.X));

            
            test.Clear(Color.Gray);
            test.ResetTransform();

            if (MousePosition.X != 0)
            {
                test.RotateTransform((float)Math.Atan((double)(((double)(Form1.ActiveForm.Top-MousePosition.Y) / (double)(Form1.ActiveForm.Top-20-MousePosition.X)))) / (float)Math.PI * 180.0f - 45);
            }
            
            test.DrawLine(pioro, new Point(0, 0), new Point(40, 40));
           // pictureBox1.Refresh();
            pictureBox1.Update();
        }
    }
}
