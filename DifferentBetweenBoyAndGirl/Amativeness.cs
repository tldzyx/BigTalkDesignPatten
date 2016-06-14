using System;

namespace DifferentBetweenBoyAndGirl
{
    internal class Amativeness : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{nameof(Man)} {nameof(Amativeness)} 时，凡事不懂也要装懂。");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{nameof(Woman)} {nameof(Amativeness)} 时，遇事懂也装作不懂。");
        }
    }
}