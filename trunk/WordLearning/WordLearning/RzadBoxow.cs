using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace WordLearning
{
    public partial class RzadBoxow
    {
        public List<CheckBox> lista;
        CheckBox temp;
        public RzadBoxow(int ile, int x, int y)
        {
            lista = new List<CheckBox>();
            for (int i = 0; i < ile; i++)
            {
                temp = new CheckBox();
                temp.Width = 15;
                temp.Text = "a";
                
                temp.Left = x+i*90;
                
                temp.Top = y;
                
                lista.Add(temp);
            }
            
        }
        public void rozszerzRzad()
        {
            temp = new CheckBox();
            temp.Width = 15;
            temp.Text = "a";

            temp.Left = 0;

            temp.Top = 0;

            lista.Add(temp);
            
        }
        

    }
}
