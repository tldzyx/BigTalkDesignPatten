namespace MediatorPatten
{
    // 抽象中介者类
    internal abstract class Mediator
    {
        // 定义一个抽象的发送消息方法，得到同事对象和发送消息
        public abstract void Send(string message, Colleague colleague);
    }
}