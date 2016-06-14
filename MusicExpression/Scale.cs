using System;

namespace MusicExpression
{
    internal class Scale : Expression
    {
        public override void Excute(string playKey, double playValue)
        {
            var scale = string.Empty;
            switch ((int) playValue)
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.Write(scale);
            Console.Write(" ");
        }
    }
}