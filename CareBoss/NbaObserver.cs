using System;

namespace CareBoss
{
    internal class NbaObserver
    {
        private readonly string _name;
        private readonly ISubject _subject;

        public NbaObserver(string name, ISubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseNbaDirectSeeding()
        {
            Console.WriteLine($"{_subject.SubjectState} {_name} 关闭NBA直播，继续工作！");
        }
    }
}