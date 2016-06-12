namespace PersonBuilder
{
    internal class PersonDirector
    {
        public void CreatePerson(PersonBuilder personBuilder)
        {
            // 头
            personBuilder.BuildHead();
            // 身体
            personBuilder.BuildBody();
            // 左手
            personBuilder.BuildArmLeft();
            // 右手
            personBuilder.BuildArmRight();
            // 左脚
            personBuilder.BuildLegLeft();
            // 右脚
            personBuilder.BuildLegRight();
        }
    }
}