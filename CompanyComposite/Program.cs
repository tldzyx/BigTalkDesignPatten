using System;

namespace CompanyComposite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Company root = new ConcreteCompany("北京总公司");
            root.Add(new HrDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            Company huadong = new ConcreteCompany("上海华东分公司");
            huadong.Add(new HrDepartment("华东分公司人力资源部"));
            huadong.Add(new FinanceDepartment("华东分公司财务部"));
            root.Add(huadong);

            Company nanjing = new ConcreteCompany("南京办事处");
            nanjing.Add(new HrDepartment("南京办事处人力资源部"));
            nanjing.Add(new FinanceDepartment("南京办事处财务部"));
            huadong.Add(nanjing);

            Company hangzhou = new ConcreteCompany("杭州办事处");
            hangzhou.Add(new HrDepartment("杭州办事处人力资源部"));
            hangzhou.Add(new FinanceDepartment("杭州办事处财务部"));
            huadong.Add(hangzhou);

            Console.WriteLine();
            Console.WriteLine("结构图：");
            root.Display(0);

            Console.WriteLine();
            Console.WriteLine("职责：");
            root.LineOfDuty();

            Console.ReadKey(true);
        }
    }
}