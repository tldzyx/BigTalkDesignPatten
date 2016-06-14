using System;

namespace UnitedCountry
{
    internal class USA : Country
    {
        public USA(UnitedNations mediator)
            : base(mediator)
        {
        }

        public void Declare(string message)
        {
            Mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"美国获得对方信息：{message}");
        }
    }
}