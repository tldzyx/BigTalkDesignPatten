using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkState
{
    class ForceRest : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间：{work.Hour}点 员工必须在20点之前离开公司");
        }
    }
}
