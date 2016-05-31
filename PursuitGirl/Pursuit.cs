using System;

namespace PursuitGirl
{
    public class Pursuit : IGiveGift
    {
        private readonly SchoolGirl _mm;

        public Pursuit(SchoolGirl mm)
        {
            _mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine(_mm.Name + " 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(_mm.Name + " 送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(_mm.Name + " 送你洋巧克力");
        }
    }
}