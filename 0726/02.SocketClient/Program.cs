using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Edukit_socket_client
{
    internal class Program
    {
        static bool bTimer = false;
        static Socket socket = null;
        static void Main()
        {
            Timer timer = new Timer(timerCallback, null, 0, 3000);
            Console.WriteLine("This is socket Client");
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("192.168.0.64"), 52644);
            socket.Connect(iPEndPoint);
            string cmd = "";
            byte[] recieveBuff = new byte[1024];
            Console.WriteLine("Connect Success!");
            Console.WriteLine("If you want to know time, type ON");
            while((cmd = Console.ReadLine()) != "Q")
            {
                byte[] buff = Encoding.UTF8.GetBytes(cmd);
                if (bTimer)
                {
                    if(cmd == "OFF")
                    {
                        bTimer = false;
                    }
                }
                else
                {
                    if(cmd == "ON")
                    {
                        bTimer = true;
                    }
                    socket.Send(buff, SocketFlags.None);
                    int n = socket.Receive(recieveBuff);
                    string data = Encoding.UTF8.GetString(buff);
                    Console.WriteLine(data);
                }
            }
            socket.Close();
            static void timerCallback(object o)
            {
                if (bTimer)
                {
                    Console.WriteLine($"현재시간 : {DateTime.Now}");
                }
            }
        }
    }
}