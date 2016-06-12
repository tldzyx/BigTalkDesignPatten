using System;

namespace WorkState
{
    internal class SleepingState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 不行了，睡着了");
        }
    }
}