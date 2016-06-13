namespace IteratorPatten
{
    internal class ConcreteIterator<T> : Iterator<T>
    {
        private readonly ConcreteAggregate<T> _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate<T> aggregate)
        {
            _aggregate = aggregate;
            _current = 0;
        }

        public override T First()
        {
            return _aggregate[0];
        }

        public override T Next()
        {
            T result = default(T);
            ++_current;
            if (_current < _aggregate.Count)
            {
                result = _aggregate[_current];
            }
            return result;
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count ? true : false;
        }

        public override T CurrentItem()
        {
            return _aggregate[_current];
        }
    }
}