using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trader;

namespace Trader
{
    class CandleRetriever
    {
   
        
        public CandleRetriever()
        {

           
        }

       
        public void Build12HourCandleAndDisplay()
        {
            GlobalObjects.one12HoursCandle.Clear();
            Candle c = new Candle();
            UpdateCandleLast12Hours();
            c.High = GlobalObjects.listof12Candles.Max(a => a.High);
            c.Low = GlobalObjects.listof12Candles.Min(a => a.Low);
            c.Open = GlobalObjects.listof12Candles.Last<Candle>().Open;
            c.Close = GlobalObjects.listof12Candles.First<Candle>().Close;

            GlobalObjects.one12HoursCandle.Add(c);
            

        }
        private void UpdateCandleLast12Hours()
        {

            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            bool areWeAM = (string.Compare(datetime.ToString("tt"), "AM") == 0);

            // gets AM / PM MessageBox.Show(datetime.ToString("tt"));
            if (datetime.Hour >= 0 && datetime.Second > 0 && datetime.Hour < 12 && areWeAM)
            {
                GlobalObjects.Candles = GlobalObjects.bitmex.GetCandleHistory(GlobalObjects.ActiveInstrument.Symbol, Convert.ToInt32(100), "1h");
                // Candles.Where(a => a.TimeStamp.Hour <= 2).Take(12);
                GlobalObjects.listof12Candles = GlobalObjects.Candles.Where(a => ((a.TimeStamp.Hour == 0 && (string.Compare((a.TimeStamp.ToString("tt")), "AM") == 0)) || (a.TimeStamp.Hour <= 23 && a.TimeStamp.Hour >= 13 && (string.Compare((a.TimeStamp.ToString("tt")), "PM") == 0)))).OrderByDescending(a => a.TimeStamp).Take(12).ToList<Candle>();
                //.OrderByDescending(a =>a.TimeStamp).Take(12).ToList<Candle>();
                // listof12Candles = Candles.Where(a => ( a.TimeStamp.Hour <= 23 && a.TimeStamp.Hour >=13)).Take(10).OrderByDescending(a => a.TimeStamp).ToList<Candle>();
                GlobalObjects.tradeTime = 1;
            }
            else if (datetime.Hour >= 12 && datetime.Second > 0 && !areWeAM)
            {
                GlobalObjects.Candles = GlobalObjects.bitmex.GetCandleHistory(GlobalObjects.ActiveInstrument.Symbol, Convert.ToInt32(100), "1h");
                GlobalObjects.listof12Candles = GlobalObjects.Candles.Where(a => ((a.TimeStamp.Hour == 12 && (string.Compare((a.TimeStamp.ToString("tt")), "PM") == 0)) || (a.TimeStamp.Hour <= 12 && a.TimeStamp.Hour >= 1 && (string.Compare((a.TimeStamp.ToString("tt")), "AM") == 0)))).OrderByDescending(a => a.TimeStamp).Take(12).ToList<Candle>();
                GlobalObjects.tradeTime = 2;
            }

        }
    }
}
