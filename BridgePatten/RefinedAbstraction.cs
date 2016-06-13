namespace BridgePatten
{
    internal class RefinedAbstraction : Abstraction
    {
        public override void Operator()
        {
            Implementor.Operation();
        }
    }
}