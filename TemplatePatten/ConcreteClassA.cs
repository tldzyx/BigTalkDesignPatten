using System;

namespace TemplatePatten
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类A方法1实现");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类A方法2实现");
        }
    }
}