using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testObrotu
{
    public partial class Form1 : Form
    {
        int kierunek_ustalony;
        int kierunek_odczytany=0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = kierunek_odczytany.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kierunek_odczytany += 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kierunek_odczytany -= 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = kierunek_odczytany.ToString();
        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (kierunek_ustalony < kierunek_odczytany)
            {
                kierunek_ustalony++;
            }
            else if (kierunek_ustalony > kierunek_odczytany)
            {
                kierunek_ustalony--;
            }
            label3.Text = kierunek_ustalony.ToString();
        }
    }
}
