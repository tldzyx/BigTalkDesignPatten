namespace AddMoney
{
    // 管理者
    internal abstract class Manager
    {
        public static readonly string 经理 = "经理";
        public static readonly string 总监 = "总监";
        public static readonly string 总经理 = "总经理";

        public Manager(string name)
        {
            Name = name;
        }

        protected string Name { get; }

        protected Manager Superior { get; private set; }

        public void SetSuperior(Manager superior)
        {
            Superior = superior;
        }

        public abstract void RequestApplications(Request request);
    }
}