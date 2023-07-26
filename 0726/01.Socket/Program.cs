using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Edukit_socket_svr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is socket SVR Program");
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 52644);
            socket.Bind(iPEndPoint);
            socket.Listen(10);
            Socket clientSocket = socket.Accept();
            byte[] buff = new byte[1024];
            while (!Console.KeyAvailable)
            {
                int n = clientSocket.Receive(buff);
                string data = Encoding.UTF8.GetString(buff, 0, n);
                Console.WriteLine(data);
                clientSocket.Send(buff, 0, n, SocketFlags.None);
            }
            clientSocket.Close();
            socket.Close();
        }
    }
}