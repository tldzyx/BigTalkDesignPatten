using System;

namespace MusicExpression
{
    internal class Note : Expression
    {
        public override void Excute(string playKey, double playValue)
        {
            var note = string.Empty;
            switch (playKey)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }
            Console.Write(note);
            Console.Write(" ");
        }
    }
}