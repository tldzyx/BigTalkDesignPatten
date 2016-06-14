using System;

namespace DifferentBetweenBoyAndGirl
{
    internal class Sucess : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{nameof(Man)} {nameof(Sucess)} 时，背后多半有一个伟大的女人。");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{nameof(Woman)} {nameof(Sucess)} 时，背后大多有一个不成功的男人。");
        }
    }
}