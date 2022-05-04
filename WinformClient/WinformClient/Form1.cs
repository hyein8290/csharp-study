using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WinformClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ipTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void portTxt_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         *  connectBtn Click하면 동작
         *  1. ip, port번호를 가져온다
         *  2. server로 접속
         */
        private void connectBtn_Click(object sender, EventArgs e)
        {
            String ip = ipTxt.Text;
            int port = Convert.ToInt32(portTxt.Text); // String을 int로 변환

            // TODO 유효성 체크

            TcpClient client = new TcpClient();
            client.Connect(ip, port);

            byte[] buf = Encoding.UTF8.GetBytes("클라이언트 : 접속합니다");
            client.GetStream().Write(buf, 0, buf.Length);

            client.Close();
        }
    }
}
