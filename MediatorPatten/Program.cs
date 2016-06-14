using System;

namespace MediatorPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.SetConcreteColleague1(colleague1);
            mediator.SetConcreteColleague2(colleague2);

            colleague1.Send("吃过饭了吗？");
            colleague2.Send("没有呢，你打算请客？");

            Console.ReadKey(true);
        }
    }
}