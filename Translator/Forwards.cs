using System;

namespace Translator
{
    internal class Forwards : Player
    {
        public Forwards(string name)
            : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"前锋 {Name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋 {Name} 防守");
        }
    }
}