using System;

namespace CompositePatten
{
    internal class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "|---" + Name);
        }
    }
}