namespace Calc.Operations
{
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberLeft*NumberRight;
        }
    }
}