namespace ShopCash.Cashs
{
    /// <summary>
    /// 打折收费
    /// </summary>
    public class CashRebate : CashSuper
    {
        private readonly double _moneyRebate;

        public CashRebate(double moneyRebate)
        {
            _moneyRebate = moneyRebate;
        }

        public override double AcceptCash(double money)
        {
            return money*_moneyRebate;
        }
    }
}