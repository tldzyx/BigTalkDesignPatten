using System;

namespace StatePatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 设置Context的初始状态为ConcreteStateA
            var context = new Context(new ConcreteStateA());

            // 不断地请求，同时更改状态
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.ReadKey(true);
        }
    }
}