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
        // nese deserializirat, smqtat se na ruka; nie si gi pishem
        //public int PCC { get; set; } // previuos candle count, za da se uverim ,che imame moving average calculation, ako nqmame 50 sveti, ne mojesm da smetnem za 50 average
        //public double? MA1 { get; set; } // ako nqmame dostatuchno predishni sveshti, tzi stoinost shte e 0la
        // public double? MA2 { get; set; } // i tazi
    }
}
