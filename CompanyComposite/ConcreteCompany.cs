using System;
using System.Collections.Generic;

namespace CompanyComposite
{
    internal class ConcreteCompany : Company
    {
        private readonly IList<Company> _children = new List<Company>();

        public ConcreteCompany(string name)
            : base(name)
        {
        }

        public override void Add(Company company)
        {
            _children.Add(company);
        }

        public override void Remove(Company company)
        {
            _children.Remove(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "|---" + Name);

            foreach (Company company in _children)
            {
                company.Display(depth + 3);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company company in _children)
            {
                company.LineOfDuty();
            }
        }
    }
}