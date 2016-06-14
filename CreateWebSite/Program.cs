using System;

namespace CreateWebSite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WebSiteFactory factory = new WebSiteFactory();

            WebSite fx = factory.GetWebSiteCategory("产品展示");
            fx.Use(new User("小菜"));

            WebSite fy = factory.GetWebSiteCategory("产品展示");
            fy.Use(new User("大鸟"));

            WebSite fz = factory.GetWebSiteCategory("产品展示");
            fz.Use(new User("娇娇"));

            WebSite fl = factory.GetWebSiteCategory("博客");
            fl.Use(new User("老顽童"));

            WebSite fm = factory.GetWebSiteCategory("博客");
            fm.Use(new User("桃谷六仙"));

            WebSite fn = factory.GetWebSiteCategory("博客");
            fn.Use(new User("南海鳄神"));

            Console.WriteLine($"网站分类总数为 {factory.GetWebSiteCount()}");

            Console.ReadKey(true);
        }
    }
}