using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePatten.SubSystem;

namespace FacadePatten
{
    /// <summary>
    /// 外观类
    /// 知道哪些子系统类负责处理请求，将客户的请求代理给适当的子系统对象
    /// 它需要了解所有的子系统的方法或属性，进行组合，以备外界调用
    /// </summary>
    internal class Facade
    {
        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine();
            Console.WriteLine("方法组A() ---- ");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine();
            Console.WriteLine("方法组B() ---- ");
            _two.MethodTwo();
            _three.MethodThree();
        }
    }
}
