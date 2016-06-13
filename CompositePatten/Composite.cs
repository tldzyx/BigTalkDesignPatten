using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CompositePatten
{
    internal class Composite : Component
    {
        private readonly ICollection<Component> _children = new Collection<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "|---" + Name);

            foreach (Component component in _children)
            {
                component.Display(depth + 3);
            }
        }
    }
}