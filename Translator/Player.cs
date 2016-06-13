namespace Translator
{
    // 球员
    internal abstract class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        protected string Name { get; }

        public abstract void Attack();

        public abstract void Defense();
    }
}