using System;

namespace Translator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Player b = new Forwards("巴蒂尔");
            Player m = new Guards("麦克格雷迪");
            ForeignCenter y = new ForeignCenter("姚明");
            Translator f = new Translator(y);

            b.Attack();
            m.Attack();
            f.Attack();
            f.Defense();

            Console.ReadKey(true);
        }
    }
}