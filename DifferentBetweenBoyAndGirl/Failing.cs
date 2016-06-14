using System;

namespace DifferentBetweenBoyAndGirl
{
    internal class Failing : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{nameof(Man)} {nameof(Failing)} 时，闷头喝酒，谁也不用劝。");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{nameof(Woman)} {nameof(Failing)} 时，眼泪汪汪，谁也劝不了。");
        }
    }
}