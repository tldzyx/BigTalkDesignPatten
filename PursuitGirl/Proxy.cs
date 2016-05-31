namespace PursuitGirl
{
    public class Proxy : IGiveGift
    {
        private readonly Pursuit _gg;

        public Proxy(SchoolGirl mm)
        {
            _gg = new Pursuit(mm);
        }

        public void GiveDolls()
        {
            _gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            _gg.GiveFlowers();
        }

        public void GiveChocolate()
        {
            _gg.GiveChocolate();
        }
    }
}