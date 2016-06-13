namespace BBQ
{
    internal class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecure receiver)
            : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            Receiver.BakeMutton();
        }

        public override string ToString()
        {
            return "烤羊肉串";
        }
    }
}