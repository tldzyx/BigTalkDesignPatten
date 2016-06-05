using System;

namespace FacadePatten.SubSystem
{
    /// <summary>
    /// 子系统类集合
    /// 实现子系统的功能，处理Facade的任何信息，既没有对Facade对象的引用
    /// </summary>
    internal class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }
}