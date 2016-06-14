using System;

namespace FlyweightPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var extrinsicState = 22;

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicState);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicState);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicState);

            Flyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicState);

            Console.ReadKey(true);
        }
    }
}