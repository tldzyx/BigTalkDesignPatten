using System;

namespace ProxyPatten
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("真实的请求");
        }
    }
}