using System;

namespace StrategyPatten.Strategies
{
    /// <summary>
    ///     具体算法A
    /// </summary>
    public class ConcreteStrategyA : Strategy
    {
        /// <summary>
        ///     算法A实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}