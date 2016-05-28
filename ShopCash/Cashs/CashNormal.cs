namespace ShopCash.Cashs
{
    /// <summary>
    /// 正常收费
    /// </summary>
    public class CashNormal : CashSuper
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}