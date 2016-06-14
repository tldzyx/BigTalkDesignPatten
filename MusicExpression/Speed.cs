using System;

namespace MusicExpression
{
    internal class Speed : Expression
    {
        public override void Excute(string playKey, double playValue)
        {
            string speed;
            if (playValue < 500)
            {
                speed = "快速";
            }
            else if (playValue >= 1000)
            {
                speed = "慢速";
            }
            else
            {
                speed = "中速";
            }

            Console.Write(speed);
            Console.Write(" ");
        }
    }
}