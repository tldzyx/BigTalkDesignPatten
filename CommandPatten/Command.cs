namespace CommandPatten
{
    internal abstract class Command
    {
        public Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        protected Receiver Receiver { get; }

        public abstract void Execute();
    }
}