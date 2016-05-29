using System;

namespace DecoratorPatten.Decorators
{
    /// <summary>
    /// 具体的装饰对象，起到给Component添加职责的功能
    /// </summary>
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体装饰对象B的操作");
        }

        private void AddedBehavior()
        {
        }
    }
}