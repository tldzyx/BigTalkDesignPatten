using System;

namespace ShopCash.Cashs
{
    /// <summary>
    ///     返利收费
    /// </summary>
    public class CashReturn : CashSuper
    {
        private readonly double _moneyCondition;

        private readonly double _moneyReturn;

        public CashReturn(double moneyCondition, double moneyReturn)
        {
            _moneyCondition = moneyCondition;
            _moneyReturn = moneyReturn;
        }

        public override double AcceptCash(double money)
        {
            if (money >= _moneyCondition)
            {
                return money - Math.Floor(money/_moneyCondition)*_moneyReturn;
            }

            return money;
        }
    }
}