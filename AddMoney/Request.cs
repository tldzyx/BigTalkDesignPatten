namespace AddMoney
{
    // 申请
    internal class Request
    {
        // 申请类别
        public string RequestType { get; set; }

        public static readonly string 请假 = "请假";
        public static readonly string 加薪 = "加薪";

        // 申请内容
        public string RequestContent { get; set; }

        // 数量
        public int Number { get; set; }
    }
}