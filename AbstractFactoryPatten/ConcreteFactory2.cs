namespace AbstractFactoryPatten
{
    internal class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProduceB CreateProductB()
        {
            return new ProductB2();
        }
    }
}