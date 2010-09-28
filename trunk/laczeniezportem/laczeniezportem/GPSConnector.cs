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
            port.BaudRate = 9600;//9600
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.Open();
            
            exception = "";
            
            try
            {
                temp = port.ReadLine();
            }
            catch (Exception ex)
            {
                String datastr = ex.Message + ", " + ex.StackTrace;
                exception = datastr;
                temp = datastr;
                port.Close();
               // return datastr;
            }
            port.Close();
      
            return temp;
        }

    }
}
