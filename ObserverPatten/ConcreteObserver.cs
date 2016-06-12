using System;

namespace ObserverPatten
{
    internal class ConcreteObserver : Observer
    {
        private readonly string _name;
        private readonly ConcreteSubject _subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            _name = name;
            _subject = subject;
        }

        public string ObserverState => _subject.SubjectState;

        public override void Update()
        {
            Console.WriteLine($"观察者 {_name} 的新状态是 {ObserverState}");
        }
    }
}