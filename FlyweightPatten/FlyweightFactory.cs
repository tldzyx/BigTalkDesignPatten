using System.Collections.Generic;

namespace FlyweightPatten
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();
        
        public Flyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights.Add(key, new ConcreteFlyweight());
            }
            return _flyweights[key];
        }
    }
}