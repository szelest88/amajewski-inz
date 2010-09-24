using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;
using Tao;
using Tao.OpenGl;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;


namespace testTao
{
    public partial class Form1: Form, IMessageFilter //drugi interfejs - keyup
    {

        public Form1()
        {
            Application.AddMessageFilter(this);//keyup
            InitializeComponent();
            this.simpleOpenGlControl1.InitializeContexts();
            }
        float divs=-10;
           public float ruch=0.0f;
        public float num0 = 0.0f;
        public float obrot = 0.0f;
        //test: do FPP
        private Matrix4 cameraMatrix;
        private Vector3 location;
        private Vector3 up = Vector3.UnitY;
        private float pitch = 0.0f;
        private float facing = 0.0f;
        private Point mouseDelta;
        private Point screenCenter;
        private Point windowCenter;
        //do mojego
        float moj_ruch = 0.0f;
        float moj_obrot = 0.0f;
 
        public bool PreFilterMessage(ref Message m) 
{
           //  const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
           // const int WM_SYSKEYDOWN = 0x104;
          //  const int WM_SYSKEYUP = 0x105;
            Keys keyCode = (Keys)(int)m.WParam & Keys.KeyCode;
            if (m.Msg == WM_KEYUP && (keyCode == Keys.Left || keyCode == Keys.Right))
            {
               // moj_ruch = 0.0f;
                 moj_obrot = 0.0f;
            }
         else if (m.Msg == WM_KEYUP && (keyCode ==Keys.Down || keyCode==Keys.Up))
         {
             moj_ruch = 0.0f;
            // moj_obrot = 0.0f;
         }
         return false;

}
 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
          
            
            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int WM_SYSKEYDOWN = 0x104;
            const int WM_SYSKEYUP = 0x105;

            if (((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN)) && simpleOpenGlControl1.Focused)
            {
                //nowe, test
                if (keyData == Keys.Up)
                {
                    moj_ruch = 0.6f;
                }
                if (keyData == Keys.Down)
                {
                    moj_ruch = -0.6f;
                }
                if (keyData == Keys.Left)
                {
                    moj_obrot = -0.05f;
                }
                if (keyData == Keys.Right)
                {
                    moj_obrot = 0.05f;
                }
                //do nowego zakomentowano:
                /*
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
                 * */
            }

                //zakomentowano też:
                
            //podniesienie
                else if (((msg.Msg == WM_KEYUP) || (msg.Msg == WM_SYSKEYUP)))
                {
                 //   moj_ruch = 0.0f;
                //    moj_obrot = 0.0f;
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

            Gl.glNewList(1, Gl.GL_COMPILE);
          //  Gl.glBegin(GL.GL_TRIANGLE_STRIP);
      //      for (int i = 0; i <= 360; i++)
        //    {
                GL.Begin(BeginMode.Quads);
                GL.Color3(Color.Red);
                GL.Vertex3(1f, 4f, 0);
                GL.Color3(Color.Yellow);
                GL.Vertex3(-1f, 4f, 0);
                GL.Vertex3(-1f, 0, 0);
                GL.Vertex3(1f, 0, 0);
                GL.End();
       //     };
           // GL.End();
            Gl.glEndList();


           // Glu.gluPerspective(45, 1, 0.01, 100);
           // Glu.gluLookAt(0, 0, 2, 0.001, 0, 0, 0, 1, 0);
            cameraMatrix = Matrix4.Identity;// z nowego
            location = new Vector3(0.0f, 10.0f, 0.0f); //z nowego
            mouseDelta = new Point(); //z nowego
            System.Windows.Forms.Cursor.Position = //nowe
                new Point(Bounds.Left + Bounds.Width / 2,
                    Bounds.Top + Bounds.Height / 2);//nowe
         
        }
        
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            //do nowego zakomentowano:
            /*
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
             * */
         
            //nowe:
            //moje, poprawka bufora głębokości
            GL.Enable(EnableCap.DepthTest);
            GL.ClearColor(0, 0, 0.4f, 0);
            /*
            GL.MatrixMode(MatrixMode.Modelview);
            
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadMatrix(ref cameraMatrix);
          
            for(int x=-10;x<=10;x++)
            {
                for (int z = -10; z <= 10; z++)
                {
                    GL.PushMatrix();
                    GL.Translate((float)x * 5f, 0f, (float)z * 5f);
                    GL.Begin(BeginMode.Quads);
                    GL.Color3(Color.Red);
                    GL.Vertex3(1f, 4f, 0);
                    GL.Color3(Color.Yellow);
                    GL.Vertex3(-1f, 4f, 0);
                    GL.Vertex3(-1f, 0, 0);
                    GL.Vertex3(1f, 0, 0);
                    GL.End();
                    GL.PopMatrix();
                }
            }
          */

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            //jak updateframe
           
           
            GL.PushMatrix();
 cameraMatrix*=Matrix4.CreateTranslation(0, 0, moj_ruch);// z nowego
 GL.PushMatrix();
             cameraMatrix*=Matrix4.CreateRotationY(moj_obrot);
            GL.MatrixMode(MatrixMode.Modelview);
            
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadMatrix(ref cameraMatrix);
            GL.PushMatrix();//?
          
           
            for (int x = -50; x <= 50; x++)
            {
                for (int z = -50; z <= 50; z++)
                {



                  GL.PushMatrix();//?
                    GL.Translate(x * 5f, -2f, z * 5f );

                    
                   // GL.PopMatrix();//?
                   // GL.PushMatrix();
                   /* dla listy 
                    GL.Begin(BeginMode.Quads);
                    GL.Color3(Color.Red);
                    GL.Vertex3(1f, 4f, 0);
                    GL.Color3(Color.Yellow);
                    GL.Vertex3(-1f, 4f, 0);
                    GL.Vertex3(-1f, 0, 0);
                    GL.Vertex3(1f, 0, 0);
                    GL.End();
              *?
                    */
                    Gl.glCallList(1);
                    GL.PopMatrix();
                    //nie tu
                }
            }
            GL.PopMatrix();
            GL.PopMatrix();//?
            GL.PopMatrix();
            simpleOpenGlControl1.SwapBuffers();
           //do nowego zakomentowano:
            /*
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
             */
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                        
        }

        private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
        }

        private void simpleOpenGlControl1_Resize(object sender, EventArgs e)
        {
            screenCenter = new Point(Bounds.Left+(Bounds.Width/2),3);
            windowCenter = new Point(Width/2,Height/2);
            GL.Viewport(simpleOpenGlControl1.Left, simpleOpenGlControl1.Top, simpleOpenGlControl1.Width, simpleOpenGlControl1.Height);
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, simpleOpenGlControl1.Width / (float)simpleOpenGlControl1.Height, 1.0f, 64.0f);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
        }

        private void fc(object sender, FormClosedEventArgs e)
        {
            Application.RemoveMessageFilter(this);
        }
    }
}
