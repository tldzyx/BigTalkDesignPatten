using System;

namespace PrototypePatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new ConcretePrototype1("I");
            // 克隆类ConcretePrototype1的对象p1就能得到新的实例c1
            var c1 = (ConcretePrototype1) p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            Console.ReadKey(true);
        }
    }
}