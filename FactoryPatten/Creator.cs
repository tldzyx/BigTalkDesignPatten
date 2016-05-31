namespace FactoryPatten
{
    /// <summary>
    /// 声明工厂方法，该方法返回一个Product类型的对象
    /// </summary>
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}