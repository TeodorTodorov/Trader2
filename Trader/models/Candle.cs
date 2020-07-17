using System;
using Trader;


namespace Trader
{
    public class Candle
    {


        public DateTime TimeStamp { get; set; }
        public double? Open { get; set; }
        public double? Close { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Volume { get; set; }
        public int Trades { get; set; }
        public override string ToString()
        {
            return "Open: " + Open + " " + "Close: " + Close + " " + "High: " + High + " " + "Low: " + Low;


        }
    }
}
