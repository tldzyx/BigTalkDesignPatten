namespace Calc.Operations
{
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberLeft + NumberRight;
        }
    }
}