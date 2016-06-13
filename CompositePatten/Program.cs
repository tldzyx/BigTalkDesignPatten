using System;

namespace CompositePatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite composite1 = new Composite("Composite X");
            composite1.Add(new Leaf("Leaf XA"));
            composite1.Add(new Leaf("Leaf XB"));
            root.Add(composite1);

            Composite composite2 = new Composite("Composite XY");
            composite2.Add(new Leaf("Leaf XYA"));
            composite2.Add(new Leaf("Leaf XYB"));
            composite1.Add(composite2);

            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(0);

            Console.ReadKey(true);
        }
    }
}