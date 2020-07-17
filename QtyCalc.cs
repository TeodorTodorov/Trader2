using System;

public class QtyCalc
{
    public QtyCalc()
    {
    }
    // step 2
        int calcStopMarketSELLQtyStep2(Order o)
        {
            return 2 * Convert.ToInt32(o.OrderQty);
        }
        int calcStopMarketBUYQtyStep2(Order o)
        {
            return 2 * Convert.ToInt32(o.OrderQty);
        }
        // step 3
        int calcTakeProfitBuyQtyStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2);
        }
        int calcStopMarketBUYQtyceStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty);
        }
        int calcTakeProfitSellQtyStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2);
        }
        int calcStopMarketSellQtyStep3(Order o)
        {
            return Convert.ToInt32(o.OrderQty);
        }
        // step 4
        int calcStopMarketSELLQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }
        int calcStopMarketBUYQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }
        int calcTakeProfitSELLQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }
        int calcTakeProfitBUYQtyStep4(Order o)
        {
            return Convert.ToInt32(o.OrderQty / 2.0);
        }

    
}
