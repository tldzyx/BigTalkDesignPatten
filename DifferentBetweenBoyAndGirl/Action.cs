using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentBetweenBoyAndGirl
{
    abstract class Action
    {
        // 得到男人结论或反应
        public abstract void GetManConclusion(Man man);

        // 得到女人结论或反应
        public abstract void GetWomanConclusion(Woman woman);
    }
}
