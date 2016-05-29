using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DecoratorPatten.Decorators;

namespace DecoratorPatten
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent component = new ConcreteComponent();
            ConcreteDecoratorA da = new ConcreteDecoratorA();
            ConcreteDecoratorB db = new ConcreteDecoratorB();

            da.SetComponent(component);
            db.SetComponent(da);
            db.Operation();

            Console.ReadKey(true);
        }
    }
}
