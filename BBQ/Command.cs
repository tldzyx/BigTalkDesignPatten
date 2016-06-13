namespace BBQ
{
    internal abstract class Command
    {
        protected Command(Barbecure receiver)
        {
            Receiver = receiver;
        }

        protected Barbecure Receiver { get; }

        public abstract void ExecuteCommand();
    }
}