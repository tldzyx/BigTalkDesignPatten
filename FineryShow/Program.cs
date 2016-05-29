using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineryShow.Decorators;

namespace FineryShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine(Environment.NewLine + "第一种装扮：");

            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine(Environment.NewLine + "第二种装扮：");

            LeatherShoes px = new LeatherShoes();
            Tie ld = new Tie();
            Suit xz = new Suit();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.WriteLine(Environment.NewLine + "第三种装扮：");

            Sneakers pqx2 = new Sneakers();
            LeatherShoes px2 = new LeatherShoes();
            BigTrouser kk2 = new BigTrouser();
            Tie ld2 = new Tie();

            pqx2.Decorate(xc);
            px2.Decorate(pqx2);
            kk2.Decorate(px2);
            ld2.Decorate(kk2);
            ld2.Show();

            Console.ReadKey(true);
        }
    }
}
