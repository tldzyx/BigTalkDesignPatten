using System;

namespace AddMoney
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manager jinli = new CommonManager("金利");
            Manager zongjian = new Majordomo("宗剑");
            Manager zhongjingli = new GeneralManager("钟精励");
            jinli.SetSuperior(zongjian);
            zongjian.SetSuperior(zhongjingli);

            Request request = new Request();
            request.RequestType = Request.请假;
            request.RequestContent = "小菜请假";
            request.Number = 1;
            jinli.RequestApplications(request);

            request = new Request();
            request.RequestType = Request.请假;
            request.RequestContent = "小菜请假";
            request.Number = 4;
            jinli.RequestApplications(request);

            request = new Request();
            request.RequestType = Request.加薪;
            request.RequestContent = "小菜请求加薪";
            request.Number = 500;
            jinli.RequestApplications(request);

            request = new Request();
            request.RequestType = Request.加薪;
            request.RequestContent = "小菜请求加薪";
            request.Number = 1000;
            jinli.RequestApplications(request);

            Console.ReadKey(true);
        }
    }
}