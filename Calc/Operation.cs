namespace Calc
{
    public abstract class Operation
    {
        public double NumberLeft { get; set; }

        public double NumberRight { get; set; }

        public abstract double GetResult();
    }
}