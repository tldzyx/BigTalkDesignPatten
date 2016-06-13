using System;

namespace CompanyComposite
{
    internal class HrDepartment : Company
    {
        public HrDepartment(string name)
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
            Console.WriteLine($"{Name} 员工招聘培训管理");
        }
    }
}