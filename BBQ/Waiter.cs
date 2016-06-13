using System;
using System.Collections.Generic;
using System.Linq;

namespace BBQ
{
    internal class Waiter
    {
        private readonly IList<Command> _orders = new List<Command>();

        public void SetOrder(Command command)
        {
            if (command is BakeChickenWingCommand)
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
            }
            else
            {
                _orders.Add(command);
                Console.WriteLine($"增加订单：{command} 时间：{DateTime.Now:HH:mm}");
            }
        }

        public void CancelOrder(Command command)
        {
            _orders.Remove(command);
            Console.WriteLine($"取消订单：{command} 时间：{DateTime.Now:HH:mm}");
        }

        public void Notify()
        {
            foreach (Command command in _orders.AsParallel())
            {
                command.ExecuteCommand();
            }
        }
    }
}