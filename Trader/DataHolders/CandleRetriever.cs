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

        private static CandleRetriever instance = null;
        BitmexApiConnector bitmex;
        ActiveInstrument activeInstruments;
        volatile public static int tradeTime = 0;
        volatile static List<Candle> listof12Candles = new List<Candle>();
        volatile static List<Candle> one12HoursCandle = new List<Candle>();
        volatile static List<Candle> Candles = new List<Candle>();

        private CandleRetriever()
        {
            bitmex = BitmexApiConnector.Instance;
            activeInstruments = ActiveInstrument.Instance;
        }

        public static CandleRetriever Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandleRetriever();
                }

                return instance;
            }
        }
        public void Build12HourCandle()
        {
            one12HoursCandle.Clear();
            Candle c = new Candle();
            UpdateCandleLast12Hours();
            c.High = listof12Candles.Max(a => a.High);
            c.Low = listof12Candles.Min(a => a.Low);
            c.Open = listof12Candles.Last<Candle>().Open;
            c.Close = listof12Candles.First<Candle>().Close;

            one12HoursCandle.Add(c);
        }
        private void UpdateCandleLast12Hours()
        {
            DateTime datetime = new DateTime();
            datetime = DateTime.Now;
            bool areWeAM = (string.Compare(datetime.ToString("tt"), "AM") == 0);

            // gets AM / PM MessageBox.Show(datetime.ToString("tt"));
            if (datetime.Hour >= 0 && datetime.Second > 0 && datetime.Hour < 12 && areWeAM)
            {
                Candles = bitmex.GetCandleHistory(activeInstruments.ActiveSymbol, Convert.ToInt32(100), "1h");
                // candles.Where(a => a.TimeStamp.Hour <= 2).Take(12);
                listof12Candles = Candles.Where(a => ((a.TimeStamp.Hour == 0 && (string.Compare((a.TimeStamp.ToString("tt")), "AM") == 0)) || (a.TimeStamp.Hour <= 23 && a.TimeStamp.Hour >= 13 && (string.Compare((a.TimeStamp.ToString("tt")), "PM") == 0)))).OrderByDescending(a => a.TimeStamp).Take(12).ToList<Candle>();
                //.OrderByDescending(a =>a.TimeStamp).Take(12).ToList<Candle>();
                // listof12Candles = candles.Where(a => ( a.TimeStamp.Hour <= 23 && a.TimeStamp.Hour >=13)).Take(10).OrderByDescending(a => a.TimeStamp).ToList<Candle>();
                tradeTime = 1;
            }
            else if (datetime.Hour >= 12 && datetime.Second > 0 && !areWeAM)
            {
                Candles = bitmex.GetCandleHistory(activeInstruments.ActiveSymbol, Convert.ToInt32(100), "1h");
                listof12Candles = Candles.Where(a => ((a.TimeStamp.Hour == 12 && (string.Compare((a.TimeStamp.ToString("tt")), "PM") == 0)) || (a.TimeStamp.Hour <= 12 && a.TimeStamp.Hour >= 1 && (string.Compare((a.TimeStamp.ToString("tt")), "AM") == 0)))).OrderByDescending(a => a.TimeStamp).Take(12).ToList<Candle>();
                tradeTime = 2;
            }

        }
        public Candle Candle12Hour
        {
            get { return one12HoursCandle[0]; }
        }
        public List<Candle> getBuildingCandles()
        {
            List<Candle> result = new List<Candle>(listof12Candles);
            return result;

        }
    }
}
