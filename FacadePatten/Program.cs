using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            // 由于Facade的作用，客户端可以根本不知道三个子系统类的存在
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey(true);
        }
    }
}
