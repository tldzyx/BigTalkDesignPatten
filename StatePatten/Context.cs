using System;

namespace StatePatten
{
    internal class Context
    {
        private State _state;

        // 定义Context的初始状态
        public Context(State state)
        {
            _state = state;
        }

        // 可读写的状态属性，用于读取当前状态和设置新状态
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"当前状态：{value.GetType().Name}");
            }
        }

        // 对请求做处理，并设置下一状态
        public void Request()
        {
            _state.Handle(this);
        }
    }
}