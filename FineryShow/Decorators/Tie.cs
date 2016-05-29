using System;

namespace FineryShow.Decorators
{
    public class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("领带 ");
            base.Show();
        }
    }
}