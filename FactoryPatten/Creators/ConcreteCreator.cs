using FactoryPatten.Products;

namespace FactoryPatten.Creators
{
    public class ConcreteCreator : Creator
    {
        /// <summary>
        /// 重定义工厂方法以返回一个ConcreteProduct实例
        /// </summary>
        /// <returns></returns>
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}