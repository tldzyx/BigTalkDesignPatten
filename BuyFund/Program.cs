using System;

namespace BuyFund
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund jijin = new Fund();

            // 基金购买
            jijin.BuyFund();

            // 基金赎回
            jijin.SellFund();

            Console.ReadKey(true);
        }
    }
}
