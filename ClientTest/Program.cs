using System;
using System.Collections.Generic;
using System.IO;
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

            NetworkStream ns = client.GetStream();
            //StreamReader sr = new StreamReader(ns);
            //StreamWriter sw = new StreamWriter(ns);

            byte[] buf = Encoding.UTF8.GetBytes("클라이언트 : 접속합니다");
            ns.Write(buf, 0, buf.Length);

            //ns.Close();
            //client.Close();

            //sw.WriteLine("client");
            //sw.Flush();
            //ns.Flush();

            //client.Close();
        }

        private static void M2()
        {
            Console.WriteLine("클라이언트콘솔창.");

            TcpClient client = new TcpClient();
            
            try
            {
                client.Connect("127.0.0.1", 9000);
            }
            catch
            {
                Console.WriteLine("서버 연결에 실패했습니다.");
            }
            
            Console.WriteLine("서버 연결에 성공했습니다.");

            while (true)
            {
                Console.Write("보낼 메시지: ");

                string message = Console.ReadLine();

                byte[] byteData = new byte[message.Length];
                byteData = Encoding.Default.GetBytes(message);

                client.GetStream().Write(byteData, 0, byteData.Length);
            }



        }


    }
}
