using System;
using XueLeiFeng.Factories;

namespace XueLeiFeng
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //IFactory factory = new UndergraduateFactory();
            IFactory factory = new VolunteerFactory();

            var studentA = factory.CreateLeiFeng();

            studentA.BuyRice();
            studentA.Sweep();
            studentA.Wash();

            var studentB = factory.CreateLeiFeng();

            studentB.BuyRice();
            studentB.Sweep();
            studentB.Wash();

            var studentC = factory.CreateLeiFeng();

            studentC.BuyRice();
            studentC.Sweep();
            studentC.Wash();

            Console.ReadKey(true);
        }
    }
}