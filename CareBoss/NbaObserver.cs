using System;

namespace CareBoss
{
    internal class NbaObserver : Observer
    {
        public NbaObserver(string name, Subject subject)
            : base(name, subject)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{Subject.SubjectState} {Name} 关闭NBA直播，继续工作！");
        }
    }
}