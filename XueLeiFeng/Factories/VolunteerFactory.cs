using XueLeiFeng.LeiFengs;

namespace XueLeiFeng.Factories
{
    /// <summary>
    ///     社区志愿者工厂
    /// </summary>
    public class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}