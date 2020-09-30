using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace PlainServer
{
    public class Server
    {
        public void Start()
        {
            TcpListener carServer = new TcpListener(IPAddress.Loopback, 10001);
            carServer.Start();

            TcpClient socket = carServer.AcceptTcpClient();

            DoClient(socket);
            socket.Close();
        }

        private static void DoClient(TcpClient socket)
        {
            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);

            string line = sr.ReadLine();
            Console.WriteLine(line);

            sw.WriteLine(line);
            sw.Flush();

        }
    }
}
