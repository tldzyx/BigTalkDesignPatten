using System;

namespace AddMoney
{
    // 经理
    internal class CommonManager : Manager
    {
        public CommonManager(string name)
            : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == Request.请假 && request.Number <= 2)
            {
                Console.WriteLine($"{Name}：{request.RequestContent} 数量{request.Number} 被批准");
            }
            else
            {
                Superior?.RequestApplications(request);
            }
        }
    }
}