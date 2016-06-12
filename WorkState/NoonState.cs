using System;

namespace WorkState
{
    internal class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 饿了，午饭；犯困，午休");
            }
            else
            {
                // 超过13点，则转入下午工作状态
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}