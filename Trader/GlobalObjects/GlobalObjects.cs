using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trader;

namespace Trader
{
    static class GlobalObjects
        //TODO switch to thread safe strucures- the problem is that atomicity is not guaranteed, write could happen in two steps, with read in between
        // TODO move the structures to classes, impelemnt the strategy pattern
    {
        //candles
        volatile public static CandleRetriever candleRetriever;
        volatile  public static  List<Candle> listof12Candles = new List<Candle>();
        volatile  public static List<Candle> one12HoursCandle = new List<Candle>();
        volatile  public static List<Candle> candles = new List<Candle>();
        //trade instrument(currency)
        volatile  public static List<Instrument> activeInstruments = new List<Instrument>();
        volatile public static Instrument activeInstrument = new Instrument();
        //api
        volatile public static BitmexApiConnector bitmex;
        // 1 - AM-12hour-candle-trading, 2- PM-12hour-candle trading
        // REMOVE hidden purpose variable
        volatile  public static int tradeTime = 0;
        // bot
        volatile public static bool isexecByLastPrice = false;
        volatile internal static bool isRunning = false;
        volatile  public static Dictionary<string, Order> lastOrders = new Dictionary<string, Order>();
        volatile  public static List<Position> openPositions = new List<Position>();

    }
}
