using System;

namespace AdapterPatten
{
    // 这是客户所期待的接口。目标可以是具体的或抽象的类，也可以是接口。
    internal class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}