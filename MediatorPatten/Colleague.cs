namespace MediatorPatten
{
    // 抽象同事类
    internal class Colleague
    {
        public Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }

        protected Mediator Mediator { get; }
    }
}