using System;

namespace FlyweightPatten
{
    internal class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine($"具体Flyweight：{extrinsicState}");
        }
    }
}