using System;

namespace CareBoss
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //// 前台小姐童子喆
            //var tongzizhe = new Secretary();
            //// 看股票的同事
            //var weiguancha = new StockObserver("魏关姹", tongzizhe);
            //var yiguancha = new StockObserver("易管察", tongzizhe);

            //// 前台记下了两位同事
            //tongzizhe.Attach(weiguancha);
            //tongzizhe.Attach(yiguancha);
            //// 发现老板回来
            //tongzizhe.SubjectState = "老板回来了！";
            //// 通知两个同事
            //tongzizhe.Notify();

            // 老板胡汉三
            Boss huhansan = new Boss();
            // 看股票的同事
            var weiguancha = new StockObserver("魏关姹", huhansan);
            var yiguancha = new StockObserver("易管察", huhansan);


            huhansan.Update += weiguancha.CloseStockMarket;
            huhansan.Update += yiguancha.CloseStockMarket;

            //huhansan.Detach(weiguancha);

            // 老板回来
            huhansan.SubjectState = "我胡汉三回来了！";
            // 发出通知
            huhansan.Notify();

            Console.ReadKey(true);
        }
    }
}