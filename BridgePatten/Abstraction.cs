namespace BridgePatten
{
    internal class Abstraction
    {
        protected Implementor Implementor { get; private set; }

        public void SetImplementot(Implementor implementor)
        {
            Implementor = implementor;
        }

        public virtual void Operator()
        {
            Implementor.Operation();
        }
    }
}