using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学生甲抄的试卷：");
            TestPaper studentA = new TestPaperA();
            studentA.TestQuestion1();
            studentA.TestQuestion2();
            studentA.TestQuestion3();

            Console.WriteLine("学生乙抄的试卷：");
            TestPaper studentB = new TestPaperB();
            studentB.TestQuestion1();
            studentB.TestQuestion2();
            studentB.TestQuestion3();

            Console.ReadKey(true);
        }
    }
}
