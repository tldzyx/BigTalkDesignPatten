using System;

namespace MementoPatten
{
    internal class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }

        public void Show()
        {
            Console.WriteLine($"State={State}");
        }
    }
}