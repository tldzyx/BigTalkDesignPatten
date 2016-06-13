using System;

namespace ChainOfResponsibilityPatten
{
    internal class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{typeof(ConcreteHandler2)} 处理请求 {request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }
}