namespace MediatorPatten
{
    internal class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public void SetConcreteColleague1(ConcreteColleague1 colleague)
        {
            _colleague1 = colleague;
        }

        public void SetConcreteColleague2(ConcreteColleague2 colleague)
        {
            _colleague2 = colleague;
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2?.Notify(message);
            }
            else
            {
                _colleague1?.Notify(message);
            }
        }
    }
}