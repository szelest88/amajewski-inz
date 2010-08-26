using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using Tao;
using Tao.OpenGl;


namespace testTao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.simpleOpenGlControl1.InitializeContexts();
            }
        float divs=-10;
           public float ruch=0.0f;
        public float num0 = 0.0f;
        public float obrot = 0.0f;
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
          
            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int WM_SYSKEYDOWN = 0x104;
            const int WM_SYSKEYUP = 0x105;

            if (((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN)) && simpleOpenGlControl1.Focused)
            {
                switch (keyData)
                {
                    case Keys.Down:
                        num0+=0.2f;
                        simpleOpenGlControl1.Refresh();
                        break;

                    case Keys.Up:
                        num0-=0.2f;
                        simpleOpenGlControl1.Refresh();
                        break;

                    case Keys.Left:
                        obrot = 5;
                        simpleOpenGlControl1.Refresh();
                        break;

                    case Keys.Right:
                        obrot = -5;
                        simpleOpenGlControl1.Refresh();
                        break;

                    case Keys.Space:          // Is Space Bar Being Pressed?
                        simpleOpenGlControl1.Refresh();
                        break;
                }
            }
            //podniesienie
                else if (((msg.Msg == WM_KEYUP) || (msg.Msg == WM_SYSKEYUP)) && simpleOpenGlControl1.Focused)
                {
                 
                            obrot *= -1;
                            simpleOpenGlControl1.Refresh();
                 
                     //eopodniesienie
                }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
           // Glu.gluPerspective(45, 1, 0.01, 100);
           // Glu.gluLookAt(0, 0, 2, 0.001, 0, 0, 0, 1, 0);
            
         
        }
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
           // base.OnPaint(e);
            // Clear Screen And Depth Buffer
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glBegin(Gl.GL_TRIANGLES);
            
            Gl.glColor3f(1, 1, 0);
            Gl.glVertex2f(0f, 0f);
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex2f(0.2f, 0.2f);
            Gl.glVertex2f(0f, 1f);
            
            Gl.glEnd();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {

            //Glu.gluPerspective(45, 1, 0.01, 10000);
            
            
        
            //ruch += 0.0001f;
            Gl.glTranslated(0.0001, 0, 0);
            if(obrot!=0)
            Gl.glRotated(obrot, 0, 0, 1);
         
            Gl.glBegin(Gl.GL_TRIANGLES);
            
            Gl.glColor3f(1, 1, 0);
            Gl.glVertex2f(0f, 0f);
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex2f(0.2f,0.2f);
            Gl.glVertex2f(0f, 1f);
            Gl.glEnd();
            //Glu.GLUquadric kwad = new Glu.GLUquadric();
            //Glu.gluSphere(kwad, 1.0, 10, 10);
           
          //simpleOpenGlControl1.SwapBuffers();//miast refresh
            //Gl.glFlush();
            simpleOpenGlControl1.Refresh();
            Gl.glFlush();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                        
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
