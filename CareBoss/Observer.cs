namespace CareBoss
{
    public abstract class Observer
    {
        protected Observer(string name, Subject subject)
        {
            Name = name;
            Subject = subject;
        }

        protected string Name { get; }
        protected Subject Subject { get; }

        public abstract void Update();
    }
}