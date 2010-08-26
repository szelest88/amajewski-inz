using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Text;

namespace WindowsFormsApplication1
{
    class GPSConnector
    {

        public static String GetData(String port_name, String exception)
        {
            String temp = "" ;
            SerialPort port = new SerialPort(port_name);
            port.BaudRate = 38400;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            exception = "";
            
            try
            {
                port.Open();
                temp = port.ReadLine();
                port.Close();
            }
            catch (Exception ex)
            {
                String datastr = ex.Message + ", " + ex.StackTrace;
                exception = datastr;
                port.Close();
            }
            return temp;
        }

    }
}
