using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace JsonServer
{
    public class Server
    {
        public void Start()
        {
            TcpListener carServer = new TcpListener(IPAddress.Loopback, 10002);
        }
    }
}
