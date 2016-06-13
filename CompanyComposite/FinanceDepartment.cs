using System;

namespace CompanyComposite
{
    internal class FinanceDepartment : Company
    {
        public FinanceDepartment(string name)
            : base(name)
        {
        }

        public override void Add(Company company)
        {
        }

        public override void Remove(Company company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string(' ', depth) + "|---" + Name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine($"{Name} 公司财务收支管理");
        }
    }
}