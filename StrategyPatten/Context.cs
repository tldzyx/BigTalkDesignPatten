namespace StrategyPatten
{
    /// <summary>
    ///     上下文
    /// </summary>
    public class Context
    {
        /// <summary>
        ///     具体的策略对象
        /// </summary>
        private readonly Strategy _strategy;

        /// <summary>
        ///     初始化时，传入具体的策略对象
        /// </summary>
        /// <param name="strategy">具体的策略对象</param>
        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        ///     上下文接口
        /// </summary>
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}