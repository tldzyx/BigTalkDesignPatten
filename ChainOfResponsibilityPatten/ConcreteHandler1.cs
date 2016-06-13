using System;

namespace ChainOfResponsibilityPatten
{
    internal class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine($"{typeof(ConcreteHandler1)} 处理请求 {request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }
}