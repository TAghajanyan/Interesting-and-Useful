using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry iPHost = Dns.GetHostByName("localhost");

            IPAddress address = iPHost.AddressList[0];

            IPEndPoint endPoint = new IPEndPoint(address, 8080);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            byte[] bytes = new byte[1024];

            try
            {
                socket.Bind(endPoint);
                socket.Listen(10);
                string data = null;

                while (true)
                {
                    Socket handler = socket.Accept();

                    int count = handler.Receive(bytes);

                    data = Encoding.ASCII.GetString(bytes, 0, count);
                    Console.WriteLine("Rob: " + data);

                    socket.Send(bytes);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            //Socket socket = new Socket()
        }
    }
}
