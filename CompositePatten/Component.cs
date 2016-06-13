namespace CompositePatten
{
    internal abstract class Component
    {
        public Component(string name)
        {
            Name = name;
        }

        protected string Name { get; }

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract void Display(int depth);
    }
}