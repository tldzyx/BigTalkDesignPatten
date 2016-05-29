using System;

namespace FineryShow.Decorators
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }
}