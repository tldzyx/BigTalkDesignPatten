using System.Collections.Generic;

namespace ObserverPatten
{
    /// <summary>
    ///     把所有对观察者对象的引用保存在一个聚集里，每个主题都可以有任何数量的观察者。
    ///     抽象主题提供一个接口，可以增加和删除观察者对象。
    /// </summary>
    public abstract class Subject
    {
        private readonly ISet<Observer> _observers = new HashSet<Observer>();

        // 增加观察着
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        // 移除观察者
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        // 通知观察者
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}