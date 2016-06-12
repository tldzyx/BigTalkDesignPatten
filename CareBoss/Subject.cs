namespace CareBoss
{
    /// <summary>
    ///     通知者
    /// </summary>
    public abstract class Subject
    {
        // 通知者状态
        public string SubjectState { get; set; }

        // 增加
        public abstract void Attach(Observer observer);

        // 减少
        public abstract void Detach(Observer observer);

        // 通知
        public abstract void Notify();
    }
}