using System;

namespace WorkState
{
    internal class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                // 如果完成任务，则转入下班状态
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else if (work.Hour < 20)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 加班哦，疲累之极");
            }
            else
            {
                // 超过20点，则转入强制下班状态
                work.SetState(new ForceRest());
                work.WriteProgram();
            }
        }
    }
}