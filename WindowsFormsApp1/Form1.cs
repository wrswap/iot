using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //远程连接服务器
        Socket client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
        String Ip= "127.0.0.1";
        int Port = 5000;
        int Interval = 5;//发送周期
        public Form1()
        {
            InitializeComponent();
        }
        private byte[] getSendData(string wd, string sd)
        {
            byte[] bFs = new byte[20];//16进制数据
            bFs[0] = 0;
            bFs[1] = 1;

            bFs[2] = 0;
            bFs[3] = 0;

            bFs[4] = 0;
            bFs[5] = 7;

            bFs[6] = 1;
            bFs[7] = 3;
            bFs[8] = 4;
            float fWd = getWd(wd);
            int iWd = (int)(fWd * 100);
            bFs[9] = (byte)(iWd / 255);
            bFs[10] = (byte)(iWd - bFs[9] * 255);
            float fSd = getSd(sd);
            int iSd = (int)(fSd * 100);

            bFs[11] = (byte)(iSd / 255);
            bFs[12] = (byte)(iSd - bFs[11] * 255);

            return bFs;
        }
        //十六进制转换字符串
        public static string ToHexString(byte[] bytes)
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));//转化字符串
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        //文本框输入字符串转换成浮点数模拟量
        private float getWd(string wd)
        {
            return float.Parse(wd);
        }
        private float getSd(string sd)
        {
            return float.Parse(sd);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (btStart.Text == "开始")
            {
                if (client.Connected) client.Close();//连接就断开
                //连接远程服务器
                EndPoint endPoint = new IPEndPoint(IPAddress.Parse(Ip), Port);
                client.Connect(endPoint);
                if (client.Connected)
                {
                    int iZq = Int32.Parse(TxTZq.Text);
                    if (iZq > 0) timer1.Interval = iZq * 1000;
                    timer1.Enabled = true;//开启定时发送
                    btStart.Text = "关闭";//改按钮
                }
            }
            else 
            {
                timer1.Enabled = false;
                client.Close();
                btStart.Text = "开始";
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxTSd_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbJ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (client.Connected)
            {
                byte[] bsnd = getSendData(TxTWd.Text, TxTSd.Text);
                try
                {
                    client.Send(bsnd);
                    string strSend = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "send:" + ToHexString(bsnd);
                    rtbJ1.Text = strSend + Environment.NewLine + rtbJ1.Text;
                }
                catch (Exception ex)
                {
                    rtbJ1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:remote server closed") + ex.Message +
                        Environment.NewLine + rtbJ1.Text;
                    MessageBox.Show(ex.Message);

                    client.Close();
                    btStart.Text = "开始";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
