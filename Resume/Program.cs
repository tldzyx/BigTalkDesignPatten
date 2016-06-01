using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX 公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY 公司");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");

            a.Display();
            b.Display();
            c.Display();

            Console.ReadKey(true);
        }
    }
}
