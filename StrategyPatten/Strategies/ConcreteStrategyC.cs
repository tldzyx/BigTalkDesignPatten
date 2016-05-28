using System;

namespace StrategyPatten.Strategies
{
    /// <summary>
    ///     具体算法C
    /// </summary>
    public class ConcreteStrategyC : Strategy
    {
        /// <summary>
        ///     算法C实现方法
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法C实现");
        }
    }
}