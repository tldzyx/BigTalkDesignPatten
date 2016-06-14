using System;

namespace FlyweightPatten
{
    internal class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine($"不共享的具体Flyweight：{extrinsicState}");
        }
    }
}