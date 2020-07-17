using System;

public class PriceCalculator
{
	public PriceCalculator()
	{
         // step 1
        double StopMarketBuyPriceStep1(Candle c)
        {
            if (null == c.High)
            {
                MessageBox.Show("FATAL ERROR PRICE CALC");
                
                return 0;
            }
            else
            {
                return (double)c.High + Convert.ToDouble(nudStep1StopMarketBUYPRICE.Value);
            }
        }
        double TakeProfitSellPriceStep1(Candle c) 
        {

            return this.calcStopMarketBuyPriceStep1(c) * (100 + Convert.ToDouble(nudStep1TakeProfitSELLPercent.Value)) / 100;
        }
        // DOlna chast 
        double calcStopMarketSellPriceStep1(Candle c)
        {

            if (null == c.Low)
            {
                MessageBox.Show("FATAL ERROR PRICE CALC");
                return 0;
            }
            else

            {
                return (double)c.Low + Convert.ToDouble(nudStep1StopMarketSELLPRICE.Value);
            }
        }
        double calcTakeProfitBuyPriceStep1(Candle c)
        {
            return this.calcStopMarketSellPriceStep1(c) * (100 + Convert.ToDouble(nudStep1TakeProfitBUYPercent.Value)) / 100;
        }
        // step 2
        double calcStopMarketSELLStopPriceStep2(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep2StopMarketSELLPercent.Value)) / 100;

        }
        double calcStopMarketBUYStopPriceStep2(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep2StopMarketBuyPercent.Value)) / 100;

        }
        // step 3
        double calcTakeProfitBuyStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep3TakeProfitBUYPercent.Value)) / 100;
        }

        double calcStopMarketBUYStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep3StopMarketBUYPercent.Value)) / 100;

        }
        double calcTakeProfitSellStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep3TakeProfitSELLPercent.Value)) / 100;
        }
        double calcStopMarketSellStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep3StopMarketSELLPercent.Value)) / 100;

        }
        // step 4
        double calcStopMarketSELLStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep4StopMarketSELLPercent.Value)) / 100;

        }
        double calcStopMarketBUYStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep4StopMarketBUYPercent.Value)) / 100;

        }
        double calcTakeProfitSELLStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep4TakeProfitSELLPercent.Value)) / 100;
        }
        double calcTakeProfitBUYStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.stopPx) * (100 + Convert.ToDouble(nudStep4TakeProfitBUYPercent.Value)) / 100;
            
        }


    }
}
