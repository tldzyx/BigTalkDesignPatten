namespace CompanyComposite
{
    internal abstract class Company
    {
        protected Company(string name)
        {
            Name = name;
        }

        protected string Name { get; }

        public abstract void Add(Company company);

        public abstract void Remove(Company company);

        public abstract void Display(int depth);
        // 履行职责
        public abstract void LineOfDuty();
    }
}