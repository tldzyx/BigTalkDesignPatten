using System;

namespace DifferentBetweenBoyAndGirl
{
    internal class Marriage : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine($"{nameof(Man)} {nameof(Marriage)} 时，感慨道：恋爱游戏终结时，‘有妻徒刑’遥无期。");
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine($"{nameof(Woman)} {nameof(Marriage)} 时，欣慰曰：爱情长跑路漫漫，婚姻保险保平安。");
        }
    }
}