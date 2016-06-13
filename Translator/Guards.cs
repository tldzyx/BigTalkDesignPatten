using System;

namespace Translator
{
    internal class Guards : Player
    {
        public Guards(string name)
            : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"后卫 {Name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"后卫 {Name} 防守");
        }
    }
}