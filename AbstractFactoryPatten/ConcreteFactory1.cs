namespace AbstractFactoryPatten
{
    internal class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProduceA1();
        }

        public override AbstractProduceB CreateProductB()
        {
            return new ProductB1();
        }
    }
}