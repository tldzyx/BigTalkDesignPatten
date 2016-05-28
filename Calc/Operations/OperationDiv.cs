using System;

namespace Calc.Operations
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (Math.Abs(NumberRight) < double.Epsilon)
            {
                throw new ArgumentOutOfRangeException("除数不能为0。");
            }
            return NumberLeft/NumberRight;
        }
    }
}