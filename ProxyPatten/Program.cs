using System;

namespace ProxyPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new Proxy();
            proxy.Request();

            Console.ReadKey(true);
        }
    }
}