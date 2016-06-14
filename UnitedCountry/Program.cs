using System;

namespace UnitedCountry
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil securityCouncil = new UnitedNationsSecurityCouncil();

            USA usa = new USA(securityCouncil);
            Iraq iraq = new Iraq(securityCouncil);

            securityCouncil.SetUSA(usa);
            securityCouncil.SetIraq(iraq);

            usa.Declare("不准研制核武器，否则要发动战争！");
            iraq.Declare("我们没有核武器，也不怕侵略。");

            Console.ReadKey(true);
        }
    }
}