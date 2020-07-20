using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Trader
{
    class BotApiCalls
    {
        const string SALT = "jyjs";
        BitmexApiConnector bitmex;
        CandleRetriever candleRetriever;
        ActiveInstrument activeInstrument;
        private bool isExecByLastPrice = false;


        private static BotApiCalls instance = null;

        private BotApiCalls()
        {
            bitmex = BitmexApiConnector.Instance;
            candleRetriever = CandleRetriever.Instance;
            activeInstrument = ActiveInstrument.Instance;
        }

        public static BotApiCalls Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BotApiCalls();
                }

                return instance;
            }
        }

        string GetId()
        {
            Properties.Settings.Default.idOrder = (Properties.Settings.Default.idOrder + 1);
            Properties.Settings.Default.Save();
            return (SALT + Properties.Settings.Default.idOrder.ToString());

        }
        public string Step1UP()
        {
            double price;
            candleRetriever.Build12HourCandleAndDisplay();
            price = PriceCalculator.GetPriceOrder1(candleRetriever.Candle12Hour);
            int qty = Properties.Settings.Default.BOTstartQty;
            price = Rounders.RoundBTC(price);
            string clorId = GetId();
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Buy", price, qty, isExecByLastPrice, clorId);
            return clorId;

        }
        public string Step1DOWN()
        {
            // order7
            double price = 0;
            candleRetriever.Build12HourCandleAndDisplay();
            price = PriceCalculator.GetPriceOrder7(candleRetriever.Candle12Hour);
            price = price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.BOTstartQty;
            string clorId = GetId();
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Sell", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step2Order2(Order ord)
        {
            // rebuild candle if using in different strategy
            double price = PriceCalculator.GetPriceOrder2(ord);
            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order2Quantity;
            string clorId = GetId();
            bitmex.TakeProfitMarket(activeInstrument.ActiveSymbol, "Sell", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step2Order3(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder3(ord);
            price = price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order3Quantity;
            string clorId = GetId();
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Sell", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step2Order4(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder4(ord);
            price = price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order4Quantity;
            string clorId = GetId();
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Sell", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step3Order5(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder5(ord);
            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order5Quantity;
            string clorId = GetId();
            bitmex.TakeProfitMarket(activeInstrument.ActiveSymbol, "Buy", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step3Order6(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder6(ord);
            int qty = Properties.Settings.Default.order6Quantity;
            string clorId = GetId();
            price = Rounders.RoundBTC(price);
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Buy", price, qty, isExecByLastPrice, clorId);

            return clorId;
        }

        public string Step2Order8(Order ord)
        {
            // rebuild candle if using in different strategy
            double price = PriceCalculator.GetPriceOrder8(ord);
            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order8Quantity;
            string clorId = GetId();
            bitmex.TakeProfitMarket(activeInstrument.ActiveSymbol, "Buy", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step2Order9(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder9(ord);
            price = price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order9Quantity;
            string clorId = GetId();
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Buy", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step2Order10(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder10(ord);
            price = price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order10Quantity;
            string clorId = GetId();
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Buy", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step3Order11(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder11(ord);
            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.order11Quantity;
            string clorId = GetId();
            bitmex.TakeProfitMarket(activeInstrument.ActiveSymbol, "Sell", price, qty, isExecByLastPrice, clorId);
            return clorId;
        }
        public string Step3Order12(Order ord)
        {
            double price = PriceCalculator.GetPriceOrder12(ord);
            int qty = Properties.Settings.Default.order12Quantity;
            string clorId = GetId();
            price = Rounders.RoundBTC(price);
            bitmex.MarketStop(activeInstrument.ActiveSymbol, "Sell", price, qty, isExecByLastPrice, clorId);

            return clorId;
        }
    }
}
