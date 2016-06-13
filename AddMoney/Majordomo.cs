using System;

namespace AddMoney
{
    // 总监
    internal class Majordomo : Manager
    {
        public Majordomo(string name)
            : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if (request.RequestType == Request.请假 && request.Number <= 5)
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