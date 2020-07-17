using System;


namespace Trader
{
    public static class PriceCalculator
    {

        // step 1
        public static double CalcStopMarketBuyPriceStep1(Candle c)
        {
            if (null == c.High)
            {
                //  MessageBox.Show("FATAL ERROR PRICE CALC");

                return 0;
            }
            else
            {

                return (double)c.High + Convert.ToDouble(Properties.Settings.Default.Step1StopMarketBUYPRICE);
            }
        }

        public static double CalcTakeProfitSellPriceStep1(Candle c)
        {

            return CalcStopMarketBuyPriceStep1(c) * (100 + Convert.ToDouble(Properties.Settings.Default.Step1TakeProfitSELLPercent)) / 100;
        }



        // DOlna chast 
        public static double CalcStopMarketSellPriceStep1(Candle c)
        {

            if (null == c.Low)
            {
                //MessageBox.Show("FATAL ERROR PRICE CALC");
                return 0;
            }
            else

            {

                return (double)c.Low + Convert.ToDouble(Properties.Settings.Default.Step1StopMarketSELLPRICE);
            }
        }
        public static double CalcTakeProfitBuyPriceStep1(Candle c)
        {
            return CalcStopMarketSellPriceStep1(c) * (100 + Convert.ToDouble(Properties.Settings.Default.Step1TakeProfitBUYPercent)) / 100;
        }
        // step 2
        public static double CalcStopMarketSELLStopPriceStep2(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step2StopMarketSELLPercent)) / 100;

        }
        public static double CalcStopMarketBUYStopPriceStep2(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step2StopMarketBuyPercent)) / 100;

        }
        // step 3
        public static double CalcTakeProfitBuyStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step3TakeProfitBUYPercent)) / 100;
        }

        public static double CalcStopMarketBUYStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step3StopMarketBUYPercent)) / 100;

        }
        public static double CalcTakeProfitSellStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step3TakeProfitSELLPercent)) / 100;
        }
        public static double CalcStopMarketSellStopPriceStep3(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step3StopMarketSELLPercent)) / 100;

        }
        // step 4
        public static double CalcStopMarketSELLStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step4StopMarketSELLPercent)) / 100;

        }
        public static double CalcStopMarketBUYStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step4StopMarketBUYPercent)) / 100;

        }
        public static double CalcTakeProfitSELLStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step4TakeProfitSELLPercent)) / 100;
        }
        public static double CalcTakeProfitBUYStopPriceStep4(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.Step4TakeProfitBUYPercent)) / 100;

        }



    }
}

