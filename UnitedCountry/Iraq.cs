using System;

namespace UnitedCountry
{
    internal class Iraq : Country
    {
        public Iraq(UnitedNations mediator)
            : base(mediator)
        {
        }

        public void Declare(string message)
        {
            Mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"伊拉克获得对方信息：{message}");
        }
    }
}