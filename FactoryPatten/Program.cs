using FactoryPatten.Creators;

namespace FactoryPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Creator creator = new ConcreteCreator();
            var product1 = creator.FactoryMethod();
            var product2 = creator.FactoryMethod();
        }
    }
}