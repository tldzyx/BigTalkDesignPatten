using System;

namespace BBQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Barbecure boy = new Barbecure();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommand = new BakeChickenWingCommand(boy);

            Waiter girl = new Waiter();

            girl.SetOrder(bakeMuttonCommand1);
            girl.Notify();
            girl.SetOrder(bakeMuttonCommand2);
            girl.Notify();
            girl.SetOrder(bakeChickenWingCommand);
            girl.Notify();

            Console.ReadKey(true);
        }
    }
}