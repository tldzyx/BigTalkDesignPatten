using System;
using System.Collections.Generic;

namespace BuilderPatten
{
    internal class Product
    {
        private readonly IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine("产品 创建 ----");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}