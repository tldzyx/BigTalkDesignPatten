using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder builder1 = new ConcreteBuilder1();
            director.Construct(builder1);
            Product product1 = builder1.GetResult();
            product1.Show();

            Builder builder2 = new ConcreteBuilder2();
            director.Construct(builder2);
            Product product2 = builder2.GetResult();
            product2.Show();

            Console.ReadKey(true);
        }
    }
}
