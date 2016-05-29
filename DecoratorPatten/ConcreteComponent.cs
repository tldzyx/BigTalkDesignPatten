using System;

namespace DecoratorPatten
{
    /// <summary>
    /// 定义了一个具体的对象，也可以给这个对象添加一些职责
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
}