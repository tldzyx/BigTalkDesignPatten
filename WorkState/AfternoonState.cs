using System;

namespace WorkState
{
    internal class AfternoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 下午状态还不错，继续努力");
            }
            else
            {
                // 超过17点，则转入傍晚工作状态
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}