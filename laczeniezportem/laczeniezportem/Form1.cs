using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        string port;// = "COM12";
        private void click(object sender, EventArgs e)
        {
            port = comboBox1.Text;
            backgroundWorker1.RunWorkerAsync();
        }

        private void tick(object sender, EventArgs e)
        {
            String exception = "";
            String to_append = "";
            to_append = GPSConnector.GetData(port, exception);//12?
            to_append.Trim();
            //if (to_append.Length > 2)
            // {
            textBox1.AppendText(to_append + "f");
            // }

            if (exception != "")
                label1.Text = "Nastąpilł wyjątek: " + exception;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
