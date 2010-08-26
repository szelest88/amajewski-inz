using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Resources;


namespace zabawa_z_gps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Serialport port = new SerialPort("COM12");
            port.BaudRate = 38400;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            try
            {
                port.Open();
            }
            catch (Exception ex)
            {
                DataStream datastr = "Exception: " + ex.Message + " " + ex.StackTrace;
            }
        }
    }
}
