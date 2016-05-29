namespace DecoratorPatten
{
    /// <summary>
    /// 装饰抽象类，继承了Component，从外类来扩展Component类的功能，但对于Component来说，是无需知道Decorator的存在的
    /// </summary>
    public abstract class Decorator : Component
    {
        /// <summary>
        /// 被装饰的对象
        /// </summary>
        protected Component Component { get; set; }

        /// <summary>
        /// 设置被装饰的对象
        /// </summary>
        /// <param name="component"></param>
        public void SetComponent(Component component)
        {
            Component = component;
        }

        public override void Operation()
        {
            Component?.Operation();
        }
    }
}