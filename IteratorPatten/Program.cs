using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatten
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate<string> aggregate = new ConcreteAggregate<string>();

            aggregate[0] = "大鸟";
            aggregate[1] = "小菜";
            aggregate[2] = "行李";
            aggregate[3] = "老外";
            aggregate[4] = "公交内部员工";
            aggregate[5] = "小偷";

            //Iterator<string> iterator = aggregate.CreateIterator();
            Iterator<string> iterator = new ConcreteIteratorDesc<string>(aggregate);
            string item = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine($"{iterator.CurrentItem()} 请买车票！");
                iterator.Next();
            }

            Console.ReadKey(true);
        }
    }
}
