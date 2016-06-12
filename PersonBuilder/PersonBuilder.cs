using System.Drawing;

namespace PersonBuilder
{
    internal abstract class PersonBuilder
    {

        public void Build()
        {
            // 头
            BuildHead();
            // 身体
            BuildBody();
            // 左手
            BuildArmLeft();
            // 右手
            BuildArmRight();
            // 左脚
            BuildLegLeft();
            // 右脚
            BuildLegRight();
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
}