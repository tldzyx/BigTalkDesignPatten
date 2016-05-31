using XueLeiFeng.LeiFengs;

namespace XueLeiFeng.Factories
{
    /// <summary>
    ///     学雷锋的大学生工厂
    /// </summary>
    public class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
}