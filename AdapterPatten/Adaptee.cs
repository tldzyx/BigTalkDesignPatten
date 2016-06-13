using System;

namespace AdapterPatten
{
    // 需要适配的类
    internal class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }
}