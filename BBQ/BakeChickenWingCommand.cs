namespace BBQ
{
    internal class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecure receiver)
            : base(receiver)
        {
        }

        public override void ExecuteCommand()
        {
            Receiver.BakeChickenWing();
        }
        
        public override string ToString()
        {
            return "烤鸡翅";
        }
    }
}