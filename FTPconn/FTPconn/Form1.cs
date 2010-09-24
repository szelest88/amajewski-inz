using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace FTPconn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FileInfo myInfo = new FileInfo("C:\\notki-to.doc");
            FtpWebRequest myReq;
            String url = "ftp://strony.toya.net.pl/" + myInfo.Name;
            myReq = (FtpWebRequest)FtpWebRequest.Create(url);
            myReq.Credentials = new NetworkCredential("szelest8", textBox1.Text);
            myReq.KeepAlive = false;
            myReq.Method = WebRequestMethods.Ftp.UploadFile;
            myReq.UseBinary = true;
            myReq.ContentLength = myInfo.Length;

            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            FileStream fs = myInfo.OpenRead();

            try
            {
                Stream strm = myReq.GetRequestStream();
                contentLen = fs.Read(buff, 0, buffLength);
                progressBar1.Maximum = (int)(fs.Length); //grafika
                while (contentLen != 0)
                {
                    progressBar1.Increment(buffLength); //grafika
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

 strm.Close();
                fs.Close();
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
    }
}
