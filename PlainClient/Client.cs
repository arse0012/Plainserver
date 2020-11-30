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
            TcpClient socket = new TcpClient("Localhost", 10001);
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                sw.AutoFlush = true;

                Car car = new Car("Tesla", "Red", "El23400");

                sw.WriteLine(car.ToString());
            }
            socket?.Close();
        }
    }
}
