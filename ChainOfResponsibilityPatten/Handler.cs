using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatten
{
    abstract class Handler
    {
        protected Handler Successor { get; private set; }

        // 设置继任者
        public void SetSucessor(Handler successor)
        {
            Successor = successor;
        }

        // 处理请求的抽象方法
        public abstract void HandleRequest(int request);
    }
}
