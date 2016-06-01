namespace PrototypePatten
{
    public abstract class Prototype
    {
        protected Prototype(string id)
        {
            Id = id;
        }

        public string Id { get; }

        /// <summary>
        /// 抽象类关键就是有这样一个Clone方法
        /// </summary>
        /// <returns></returns>
        public abstract Prototype Clone();
    }
}