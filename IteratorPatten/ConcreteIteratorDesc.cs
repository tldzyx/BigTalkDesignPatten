using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatten
{
    class ConcreteIteratorDesc<T> : Iterator<T>
    {
        private readonly ConcreteAggregate<T> _aggregate;
        private int _current;

        public ConcreteIteratorDesc(ConcreteAggregate<T> aggregate)
        {
            _aggregate = aggregate;
            _current = aggregate.Count - 1;
        }

        public override T First()
        {
            return _aggregate[_aggregate.Count - 1];
        }

        public override T Next()
        {
            T result = default(T);
            --_current;
            if (_current >= 0)
            {
                result = _aggregate[_current];
            }
            return result;
        }

        public override bool IsDone()
        {
            return _current < 0 ? true : false;
        }

        public override T CurrentItem()
        {
            return _aggregate[_current];
        }
    }
}
