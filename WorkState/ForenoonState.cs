using System;

namespace WorkState
{
    internal class ForenoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 上午工作，精神百倍");
            }
            else
            {
                // 超过12点，则转入中午工作状态
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}