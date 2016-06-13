using System;

namespace BridgePatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.SetImplementot(new ConcreteImplementorA());
            abstraction.Operator();

            abstraction.SetImplementot(new ConcreteImplementorB());
            abstraction.Operator();

            Console.ReadKey(true);
        }
    }
}