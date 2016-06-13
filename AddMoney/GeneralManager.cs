using System;

namespace AddMoney
{
    // 总经理
    internal class GeneralManager : Manager
    {
        public GeneralManager(string name)
            : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == Request.请假)
            {
                Console.WriteLine($"{Name}：{request.RequestContent} 数量{request.Number} 被批准");
            }
            else if (request.RequestType == Request.加薪)
            {
                if (request.Number <= 500)
                {
                    Console.WriteLine($"{Name}：{request.RequestContent} 数量{request.Number} 被批准");
                }
                else
                {
                    Console.WriteLine($"{Name}：{request.RequestContent} 数量{request.Number} 再说吧");
                }
            }
        }
    }
}