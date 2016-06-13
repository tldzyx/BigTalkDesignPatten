using System;

namespace Translator
{
    internal class ForeignCenter
    {
        public string Name { get; }

        public ForeignCenter(string name)
        {
            Name = name;
        }

        public void 进攻()
        {
            Console.WriteLine($"外籍中锋 {Name} 进攻");
        }

        public void 防守()
        {
            Console.WriteLine($"外籍中锋 {Name} 防守");
        }
    }
}