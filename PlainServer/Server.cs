using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlainServer
{
    public class Server
    {
        public Server()
        {
            
        }
        public void Start()
        {
            TcpListener carServer = new TcpListener(IPAddress.Loopback, 10001);
            carServer.Start();

            while (true)
            {
                TcpClient socket = carServer.AcceptTcpClient();
                Task.Run(
                    () =>
                    {
                        TcpClient tmpSocket = socket;
                        DoClient(tmpSocket);
                    }
                    );
            }

        }

        private static void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                sw.AutoFlush = true;

                string carString = sr.ReadLine();

                Console.WriteLine("Received car string : " + carString);
            }
            socket?.Close();
        }
    }
}
