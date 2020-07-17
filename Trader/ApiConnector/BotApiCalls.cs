using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Trader
{
    static class BotApiCalls
    {
        const string SALT = "jyj";

        static string GetId()
        {
            Properties.Settings.Default.idOrder = (Properties.Settings.Default.idOrder + 1);
            Properties.Settings.Default.Save();
            return (SALT + Properties.Settings.Default.idOrder.ToString());

        }

        static public string PlaceStep1StopMarketBuyOrder()
        {
            double price;
            GlobalObjects.candleRetriever.Build12HourCandleAndDisplay();
            price = PriceCalculator.CalcStopMarketBuyPriceStep1(GlobalObjects.one12HoursCandle[0]);



            int qty = Properties.Settings.Default.BOTstartQty;
            price = Rounders.RoundBTC(price);
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        static public string PlaceStep1TakeProfitSellOrder()
        {
            // rebuild candle if using in different strategy
            double price;

            GlobalObjects.candleRetriever.Build12HourCandleAndDisplay();
            price = PriceCalculator.CalcTakeProfitSellPriceStep1(GlobalObjects.one12HoursCandle[0]);

            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.BOTstartQty;
            string clorId = GetId();
            GlobalObjects.bitmex.TakeProfitMarket(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }


        // down
        static public string PlaceStep1StopMarketSELLOrder()
        {
            double price;

            GlobalObjects.candleRetriever.Build12HourCandleAndDisplay();
            price = PriceCalculator.CalcStopMarketSellPriceStep1(GlobalObjects.one12HoursCandle[0]);
            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.BOTstartQty;
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        static public string PlaceStep1TakeProfitBuyOrder()
        {
            double price;
            // rebuild candle if using in different strategy

            GlobalObjects.candleRetriever.Build12HourCandleAndDisplay();
            price = PriceCalculator.CalcTakeProfitBuyPriceStep1(GlobalObjects.one12HoursCandle[0]);

            price = Rounders.RoundBTC(price);
            int qty = Properties.Settings.Default.BOTstartQty;
            string clorId = GetId();
            GlobalObjects.bitmex.TakeProfitMarket(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }

        // STEP 1 closes here

        // STEP 2

        // up
        static public string PlaceStep2StopMarketSELLOrder(Order ord)
        {


            double price = PriceCalculator.CalcStopMarketSELLStopPriceStep2(ord);
             price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcStopMarketSELLQtyStep2(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        // down
        static public string PlaceStep2StopMarketBuyOrder(Order ord)
        {

            double price = PriceCalculator.CalcStopMarketBUYStopPriceStep2(ord);
            int qty = QtyCalc.CalcStopMarketBUYQtyStep2(ord);
            string clorId = GetId();
            price = Rounders.RoundBTC(price);
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);

            return clorId;
        }

        // Step 2 closes here 
        // Step 3

        // up
        static public string PlaceStep3TakeProfitBuyOrder(Order ord)
        {
            // rebuild candle if using in different strategy
            double price = PriceCalculator.CalcTakeProfitBuyStopPriceStep3(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcTakeProfitBuyQtyStep3(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.TakeProfitMarket(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }

        static public string PlaceStep3StopMarketBuyOrder(Order ord)
        {

            double price = PriceCalculator.CalcStopMarketBUYStopPriceStep3(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcStopMarketBUYQtyceStep3(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        // down

        static public string PlaceStep3TakeProfitSellOrder(Order ord)
        {
            // rebuild candle if using in different strategy
            double price = PriceCalculator.CalcTakeProfitSellStopPriceStep3(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcTakeProfitSellQtyStep3(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.TakeProfitMarket(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }

        static public string PlaceStep3StopMarketSellOrder(Order ord)
        {

            double price = PriceCalculator.CalcStopMarketSellStopPriceStep3(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcStopMarketSellQtyStep3(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        // Step 3 closes here

        // Step 4 opens here
        // up 

        static public string PlaceStep4StopMarketSellOrder(Order ord)
        {

            double price = PriceCalculator.CalcStopMarketSELLStopPriceStep4(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcStopMarketSELLQtyStep4(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        static public string PlaceStep4TakeProfitSellOrder(Order ord)
        {
            double price = PriceCalculator.CalcTakeProfitSELLStopPriceStep4(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcTakeProfitSELLQtyStep4(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.TakeProfitMarket(GlobalObjects.ActiveInstrument.Symbol, "Sell", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        // down
        static public string PlaceStep4StopMarketBuyOrder(Order ord)
        {

            double price = PriceCalculator.CalcStopMarketBUYStopPriceStep4(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcStopMarketBUYQtyStep4(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.MarketStop(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }
        static public string PlaceStep4TakeProfitBuyOrder(Order ord)
        {
            double price = PriceCalculator.CalcTakeProfitBUYStopPriceStep4(ord);
            price = Rounders.RoundBTC(price);
            int qty = QtyCalc.CalcTakeProfitBUYQtyStep4(ord);
            string clorId = GetId();
            GlobalObjects.bitmex.TakeProfitMarket(GlobalObjects.ActiveInstrument.Symbol, "Buy", price, qty, GlobalObjects.execByLastPrice, clorId);
            return clorId;
        }

    }
}
