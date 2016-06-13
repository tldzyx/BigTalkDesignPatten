namespace Translator
{
    internal class Translator : Player
    {
        private readonly ForeignCenter _center;

        public Translator(ForeignCenter center)
            : base(center.Name)
        {
            _center = center;
        }

        public override void Attack()
        {
            _center.进攻();
        }

        public override void Defense()
        {
            _center.防守();
        }
    }
}