namespace AbstractFactoryPatten
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProduceB CreateProductB();
    }
}