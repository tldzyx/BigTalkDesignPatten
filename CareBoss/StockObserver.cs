using System;

namespace CareBoss
{
    internal class StockObserver
    {
        private readonly string _name;
        private readonly ISubject _subject;

        public StockObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭股票行情，继续工作！");
        }
    }
}