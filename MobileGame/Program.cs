using System;

namespace MobileGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HandsetBrand hbn = new HandsetBrandN();

            hbn.SetHandsetSoft(new HandsetGame());
            hbn.Run();

            hbn.SetHandsetSoft(new HandsetAddressList());
            hbn.Run();

            hbn.SetHandsetSoft(new HandsetMp3());
            hbn.Run();

            HandsetBrand hbm = new HandsetBrandM();

            hbm.SetHandsetSoft(new HandsetGame());
            hbm.Run();

            hbm.SetHandsetSoft(new HandsetAddressList());
            hbm.Run();

            hbm.SetHandsetSoft(new HandsetMp3());
            hbm.Run();

            HandsetBrand hbs = new HandsetBrandS();

            hbs.SetHandsetSoft(new HandsetGame());
            hbs.Run();

            hbs.SetHandsetSoft(new HandsetAddressList());
            hbs.Run();

            hbs.SetHandsetSoft(new HandsetMp3());
            hbs.Run();

            Console.ReadKey(true);
        }
    }
}