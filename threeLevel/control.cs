using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threeLevel
{
    public partial class control : Form
    {
        private static string serverIp = "192.168.6.173";
        private static IPAddress serverip = IPAddress.Parse(serverIp);
        private static int serverPort = 9096;
        private static IPEndPoint controlServer = new IPEndPoint(serverip,serverPort);
        public control()
        {
            InitializeComponent();
        }
        private void  udpBandWidthControlCommandSend(string msg)
        {
            //使用udp发送控制命令
            try
            {
                UdpClient sender = new UdpClient();
                byte[] msg_byte = Encoding.UTF8.GetBytes(msg);
                sender.Send(msg_byte, msg_byte.Length, controlServer);
                Logger.logWrite(string.Format("发送命令{0}给{1}:{2}成功\r\t",msg,serverIp,serverPort.ToString()));
            }
            catch (Exception ee )
            {

                //throw;
                Logger.logWrite(ee.Message);
            }
        }
        private void button_band1_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link1", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }
        private void button_band2_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link2", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }
        private void button_band3_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link3", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }
        private void button_band4_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link4", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }
        private void button_band5_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link5", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }
        private void button_band6_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link6", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }
        private void button_band7_Click(object sender, EventArgs e)
        {
            int bandWidth = Convert.ToInt32(this.textBox_band1.Text);
            string msg = string.Format("{0}={1}", "link7", bandWidth);
            udpBandWidthControlCommandSend(msg);
        }

        private void button_Commit_Click(object sender, EventArgs e)
        {

        }
    }
}
