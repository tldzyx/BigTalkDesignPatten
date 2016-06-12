using System.Collections.Generic;

namespace CareBoss
{
    internal class Secretary : Subject
    {
        // 同事列表
        private readonly HashSet<Observer> _observers = new HashSet<Observer>();

        // 增加
        public override void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        // 减少
        public override void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        // 通知
        public override void Notify()
        {
            foreach (var stockObserver in _observers)
            {
                stockObserver.Update();
            }
        }
    }
}