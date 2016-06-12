using System;

namespace ObserverPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver("X", subject));
            subject.Attach(new ConcreteObserver("Y", subject));
            subject.Attach(new ConcreteObserver("Z", subject));

            subject.SubjectState = "ABC";
            subject.Notify();

            Console.ReadKey(true);
        }
    }
}