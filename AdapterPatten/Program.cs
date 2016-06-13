using System;

namespace AdapterPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.ReadKey(true);
        }
    }
}