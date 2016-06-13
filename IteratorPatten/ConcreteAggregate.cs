using System.Collections.Generic;

namespace IteratorPatten
{
    internal class ConcreteAggregate<T> : Aggregate<T>
    {
        private readonly IList<T> _items = new List<T>();

        public int Count => _items.Count;

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public override Iterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }
    }
}