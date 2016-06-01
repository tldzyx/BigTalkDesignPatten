namespace TestPaper
{
    /// <summary>
    /// 学生甲抄的试卷
    /// </summary>
    public class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "a";
        }

        protected override string Answer2()
        {
            return "c";
        }

        protected override string Answer3()
        {
            return "a";
        }
    }
}