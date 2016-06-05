using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyFund
{
    class Fund
    {
        Stock1 gu1;
        Stock2 gu2;
        Stock3 gu3;
        NationalDebt1 nd1;
        Realty1 rt1;

        public Fund()
        {
            gu1 = new Stock1();
            gu2 = new Stock2();
            gu3 = new Stock3();
            nd1 = new NationalDebt1();
            rt1 = new Realty1();
        }

        public void BuyFund()
        {
            gu1.Buy();
            gu2.Buy();
            gu3.Buy();
            nd1.Buy();
            rt1.Buy();
        }

        public void SellFund()
        {
            gu1.Sell();
            gu2.Sell();
            gu3.Sell();
            nd1.Sell();
            rt1.Sell();
        }
    }
}
