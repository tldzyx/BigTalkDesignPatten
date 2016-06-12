using System;

namespace CareBoss
{
    internal class StockObserver : Observer
    {
        public StockObserver(string name, Subject subject)
            : base(name, subject)
        {

        }

        public override void Update()
        {
            Console.WriteLine($"{Subject.SubjectState} {Name} 关闭股票行情，继续工作！");
        }
    }
}