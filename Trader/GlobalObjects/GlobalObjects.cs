using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trader;

namespace Trader
{
    static class GlobalObjects
    {
        //candles
        volatile public static CandleRetriever candleRetriever;
        volatile  public static  List<Candle> listof12Candles = new List<Candle>();
        volatile  public static List<Candle> one12HoursCandle = new List<Candle>();
        volatile  public static List<Candle> Candles = new List<Candle>();
        //trade instrument(currency)
        volatile  public static List<Instrument> ActiveInstruments = new List<Instrument>();
        volatile public static Instrument ActiveInstrument = new Instrument();
        //api
        volatile public static BitmexApiConnector bitmex;
        // 1 - AM-12hour-candle-trading, 2- PM-12hour-candle trading
        volatile  public static int tradeTime = 0;
        // bot
        volatile public static bool execByLastPrice = false;
        volatile internal static bool isRunning = false;
        volatile  public static Dictionary<string, Order> lastOrders = new Dictionary<string, Order>();
        volatile  public static List<Position> OpenPositions = new List<Position>();

    }
}
