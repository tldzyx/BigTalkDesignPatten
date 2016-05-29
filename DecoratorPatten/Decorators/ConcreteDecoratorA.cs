using System;

namespace DecoratorPatten.Decorators
{
    /// <summary>
    /// 具体的装饰对象，起到给Component添加职责的功能
    /// </summary>
    public class ConcreteDecoratorA : Decorator
    {
        private string _addedState;

        public override void Operation()
        {
            base.Operation();
            _addedState = "New State";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}