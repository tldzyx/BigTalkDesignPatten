namespace ObserverPatten
{
    /// <summary>
    ///     具体主题，将有关状态存入具体观察者对象；在具体主题的内部状态改变时，给所有登记过的观察者发出通知。
    /// </summary>
    internal class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }
}