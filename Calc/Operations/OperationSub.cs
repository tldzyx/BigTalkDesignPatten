namespace Calc.Operations
{
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            return NumberLeft - NumberRight;
        }
    }
}