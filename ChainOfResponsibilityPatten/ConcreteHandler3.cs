using System;

namespace ChainOfResponsibilityPatten
{
    internal class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{typeof(ConcreteHandler3)} 处理请求 {request}");
            }
            else
            {
                Successor?.HandleRequest(request);
            }
        }
    }
}