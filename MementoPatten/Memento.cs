namespace MementoPatten
{
    public class Memento
    {
        public Memento(string state)
        {
            State = state;
        }

        public string State { get; }
    }
}