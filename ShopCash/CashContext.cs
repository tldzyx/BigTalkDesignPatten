using ShopCash.Cashs;

namespace ShopCash
{
    public class CashContext
    {
        private readonly CashSuper _cashSuper;

        public CashContext(string strategy)
        {
            switch (strategy)
            {
                case "满300返100":
                    _cashSuper = new CashReturn(300, 100);
                    break;
                case "打8折":
                    _cashSuper = new CashRebate(0.8);
                    break;
                case "正常收费":
                    _cashSuper = new CashNormal();
                    break;
            }
        }

        public double GetResult(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}