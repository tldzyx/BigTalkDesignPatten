using System;

namespace VisitorPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ObjectStructure elements = new ObjectStructure();
            elements.Attach(new ConcreteElementA());
            elements.Attach(new ConcreteElementB());

            Visitor v1 = new ConcreteVisitor1();
            Visitor v2 = new ConcreteVisitor2();

            elements.Accept(v1);
            elements.Accept(v2);

            Console.ReadKey(true);
        }
    }
}