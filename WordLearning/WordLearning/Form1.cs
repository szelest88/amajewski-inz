using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace WordLearning
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
        int aktualna_wysokosc = 0;
        Label temp_label;
        List<Label> lista_labeli=new List<Label>();
        TextBox temp_text;
        List<TextBox> lista_textow=new List<TextBox>();
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            aktualna_wysokosc += 20;
            temp_label = new Label();
            
            temp_label.Text = "zupa";
            temp_label.Left = 20;

            temp_label.Top = aktualna_wysokosc;
            lista_labeli.Add(temp_label);
            //scroll!
            panel1.Controls.Add(temp_label);

            temp_text = new TextBox();
            temp_text.Left = 140;
            temp_text.Top = aktualna_wysokosc;
            lista_textow.Add(temp_text);
            //scroll!
            panel1.Controls.Add(temp_text);

            RzadBoxow rzad = new RzadBoxow(2,50,0);
            for (int i = 0; i < rzad.lista.Count; i++)
            {
                rzad.lista[i].Text = i.ToString();
                //scroll!
                panel1.Controls.Add(rzad.lista[i]);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
