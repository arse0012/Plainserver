using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using ModelLib;

namespace PlainClient
{
    public class Client
    {
        public void Start()
        {
            Car car = new Car("Tesla","Red","El23400");
            TcpClient socket = new TcpClient("Localhost", 10001);

            NetworkStream ns = socket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);



        }
    }
}
