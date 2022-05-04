using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientTest
{
    static class Program
    {

        static void Main(string[] args)
        {
            M1();
        }

        private static void M1()
        {
            Console.WriteLine("클라이언트콘솔창.");

            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 9000);

            byte[] buf = Encoding.UTF8.GetBytes("클라이언트 : 접속합니다");
            client.GetStream().Write(buf, 0, buf.Length);

            client.Close();
        }


    }
}
