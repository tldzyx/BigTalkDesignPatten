using System;

namespace Calc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var operation = OperationFactory.GetOperation("+");
            operation.NumberLeft = 1;
            operation.NumberRight = 2;
            var result = operation.GetResult();

            Console.WriteLine("获取结果:" + result);

            Console.ReadKey(true);
        }
    }
}