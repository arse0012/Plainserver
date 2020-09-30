using System;
using ModelLib;

namespace PlainClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client plainClient = new Client();
            plainClient.Start();

            Console.ReadLine();
        }
    }
}
