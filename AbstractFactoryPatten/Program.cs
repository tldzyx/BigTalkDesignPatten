using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new ConcreteFactory1();

            AbstractProductA productA = factory.CreateProductA();
            AbstractProduceB productB = factory.CreateProductB();
        }
    }
}
