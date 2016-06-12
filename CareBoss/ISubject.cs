namespace CareBoss
{
    public interface ISubject
    {
        // 通知者状态
        string SubjectState { get; set; }

        // 通知
        void Notify();
    }
}