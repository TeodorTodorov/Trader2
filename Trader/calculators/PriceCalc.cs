using System;


namespace Trader
{
    public static class PriceCalculator
    {
        public static double GetPriceOrder1(Candle c)
        {
            if (null == c.High)
            {
                return 0;
            }
            else
            {
                return (double)c.High + Convert.ToDouble(Properties.Settings.Default.order1Price);
            }

        }

        public static double GetPriceOrder2(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order2Percent)) / 100;
        }

        public static double GetPriceOrder3(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order3Percent)) / 100;
        }
        public static double GetPriceOrder4(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order4Percent)) / 100;
        }
        public static double GetPriceOrder5(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order5Percent)) / 100;
        }
        public static double GetPriceOrder6(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order6Percent)) / 100;
        }
        public static double GetPriceOrder7(Candle c)
        {

            if (null == c.Low)
            {
                return 0;
            }
            else

            {
                return (double)c.Low + Convert.ToDouble(Properties.Settings.Default.order7Price);
            }
        }
        public static double GetPriceOrder8(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order8Percent)) / 100;
        }
        public static double GetPriceOrder9(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order9Percent)) / 100;
        }
        public static double GetPriceOrder10(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order10Percent)) / 100;
        }
        public static double GetPriceOrder11(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order11Percent)) / 100;
        }
        public static double GetPriceOrder12(Order o)
        {
            return Convert.ToDouble(o.StopPx) * (100 + Convert.ToDouble(Properties.Settings.Default.order12Percent)) / 100;
        }

    }
}

