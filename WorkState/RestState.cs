using System;

namespace WorkState
{
    internal class RestState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 下班回家了");
        }
    }
}