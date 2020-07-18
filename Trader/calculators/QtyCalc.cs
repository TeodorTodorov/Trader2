using System;

namespace Trader
{
    public static class QtyCalc
    {

        // step 2
        public static int CalcStopMarketSELLQtyStep2(Order o)
        {
            return 2 * Convert.ToInt32(o.OrderQty);
        }

        public static int CalcStopMarketBUYQtyStep2(Order o)
        {
            return 2 * Convert.ToInt32(o.OrderQty);
        }

        // step 3
        public static int CalcTakeProfitBuyQtyStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2);
        }

        public static int CalcStopMarketBUYQtyceStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty);
        }

        public static int CalcTakeProfitSellQtyStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2);
        }

        public static int CalcStopMarketSellQtyStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty);
        }

        // step 4
        public static int CalcStopMarketSELLQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }

        public static int CalcStopMarketBUYQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }

        public static int CalcTakeProfitSELLQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }

        public static int CalcTakeProfitBUYQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }
    }
}
