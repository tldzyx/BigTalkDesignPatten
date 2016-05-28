using System;

namespace StrategyPatten.Strategies
{
    /// <summary>
    ///     具体算法B
    /// </summary>
    public class ConcreteStrategyB : Strategy
    {
        /// <summary>
        ///     算法B实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }
}