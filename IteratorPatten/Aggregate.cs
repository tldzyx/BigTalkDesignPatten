namespace IteratorPatten
{
    internal abstract class Aggregate<T>
    {
        public abstract Iterator<T> CreateIterator();
    }
}