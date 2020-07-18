
// THIS CODE IS LEGACY - result of bad programming and customer constantly changing and adding new features and requirments, the programmer tried to patch it up
// leaved only for testing, after some iterations the customer validate strong requirments and features different from the code here, to be implimented again
// not meeting clean coderequirments, leaved for demo/test purposes
// TODO : replace code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using Trader;

namespace Trader
{
    class Bot
    {


        // step 1
        // UP 
        public bool continueWithUP = true;
        public int executedStepUP = 0;
        public List<string> postedTakeProfitOrdersIDUP = new List<string>();
        public List<string> postedStopMarketOrderIDUP = new List<string>();

        public string Step1IdSMB;
        public string Step1IdTPS;
        // down 
        public bool continueWithDown = true;
        public int executedStepDown = 0;
        public string Step1IdSMS;
        public string Step1IdTPB;
        public List<string> postedTakeProfitOrdersIDDown = new List<string>();
        public List<string> postedStopMarketOrderIDDown = new List<string>();



        // step 2
        // UP
        string step2IdSMS;
        // DOWN
        string step2IdSMB;

        // step 3
        // UP
        string step3IdTPB;
        string step3IdSMB;
        // DOWN
        string step3IdTPS;
        string step3IdSMS;

        //Step 4 
        // UP
        string step4IdSMS;
        string step4IdTPS;
        // DOWN
        string step4IdSMB;
        string step4IdTPB;

        public Bot()
        {
            // GlobalObjects.bitmex = BitmexApiConnector.Instance;



        }
        Order GetOrderWithID( string id)
        {

            return GlobalObjects.lastOrders[id.ToString()];

        }

        bool IsOrderWithIDFilled(string id)
        {
            if (GlobalObjects.lastOrders.ContainsKey(id))
            {
                return String.Compare(GetOrderWithID( id).OrdStatus, "Filled") == 0;
            }
            return false;

        }
        void StartUPCandleTrading()
        {
            Step1IdSMB = BotApiCalls.PlaceStep1StopMarketBuyOrder();
            Step1IdTPS = BotApiCalls.PlaceStep1TakeProfitSellOrder();

            postedTakeProfitOrdersIDUP.Add(Step1IdTPS);
            postedStopMarketOrderIDUP.Add(Step1IdSMB);
            executedStepUP = 1;




        }
        void StartDOWNCandleTrading()
        {
            Step1IdSMS = BotApiCalls.PlaceStep1StopMarketSELLOrder();
            Step1IdTPB = BotApiCalls.PlaceStep1TakeProfitBuyOrder();

            postedTakeProfitOrdersIDDown.Add(Step1IdTPB);
            postedStopMarketOrderIDDown.Add(Step1IdSMS);

            executedStepDown = 1;
        }
        void Step1()
        {
            StartUPCandleTrading();
            StartDOWNCandleTrading();
            Console.WriteLine("[BOT] step 1 posted");

        }


        // STEP 2
        // UP
        void BOTExecuteStep2UPIfContiNueAndFilledStopMarketStep1BUY()
        {
            if (continueWithUP && IsOrderWithIDFilled(Step1IdSMB))
            {
                step2IdSMS = BotApiCalls.PlaceStep2StopMarketSELLOrder(GetOrderWithID(Step1IdSMB));
                postedStopMarketOrderIDUP.Add(step2IdSMS);
                executedStepUP = 2;
                Console.WriteLine("[BOT] step 2 up posted");
            }
        }
        // DOWN
        void BOTExecuteStep2DownIfContinueAndFilledStopMarketStep1SELL()
        {
            if (continueWithDown && IsOrderWithIDFilled(Step1IdSMS))
            {
                step2IdSMB = BotApiCalls.PlaceStep2StopMarketBuyOrder(GetOrderWithID(Step1IdSMS));
                postedStopMarketOrderIDDown.Add(step2IdSMB);
                executedStepDown = 2;
                Console.WriteLine("[BOT] step 2 down posted");
            }
        }

        // STEP 3
        // UP
        void BOTExecuteStep3UPIfContinueAndFilledStopMarketStep2Sell()
        {
            
            // if we are at up trade on 3rd step and Stop market sell from step2 is filled
            if (continueWithUP && IsOrderWithIDFilled(step2IdSMS))
            {
                GlobalObjects.bitmex.DeleteOrder(Step1IdTPS);
                step3IdTPB = BotApiCalls.PlaceStep3TakeProfitBuyOrder(GetOrderWithID(step2IdSMS));
                step3IdSMB = BotApiCalls.PlaceStep3StopMarketBuyOrder(GetOrderWithID(step2IdSMS));
                postedTakeProfitOrdersIDUP.Add(step3IdTPB);
                postedStopMarketOrderIDUP.Add(step3IdSMB);
                executedStepUP = 3;
                Console.WriteLine("[BOT] step 3 up posted");

            }
        }
        // DOWN
        void BOTExecuteStep3DownIfContinueAndFilledStopMarketStep2Buy()
        {
     
            // if we are at down trade on step 3 and stop market buy is filled from 2nd step
            if (continueWithDown && IsOrderWithIDFilled(step2IdSMB))
            {
                GlobalObjects.bitmex.DeleteOrder(Step1IdTPB);
                step3IdTPS = BotApiCalls.PlaceStep3TakeProfitSellOrder(GetOrderWithID(step2IdSMB));
                step3IdSMS = BotApiCalls.PlaceStep3StopMarketSellOrder(GetOrderWithID(step2IdSMB));
                postedTakeProfitOrdersIDDown.Add(step3IdTPS);
                postedStopMarketOrderIDDown.Add(step3IdSMS);
                executedStepDown = 3;
                Console.WriteLine("[BOT] step 3 down posted");

            }
        }

        // STEP 4
        // UP
        void BOTExecuteStep4UPIfContinueAndFilledStopMarketStep3Buy()
        {
   
            // if we are at up trade on 3rd step and step market buy from 3rd step is filled
            if (continueWithUP && IsOrderWithIDFilled(step3IdSMB))
            {
                GlobalObjects.bitmex.DeleteOrder(step3IdTPB);
                step4IdTPS = BotApiCalls.PlaceStep4TakeProfitSellOrder(GetOrderWithID(step3IdSMB));
                step4IdSMS = BotApiCalls.PlaceStep4StopMarketSellOrder(GetOrderWithID(step3IdSMB));
                postedTakeProfitOrdersIDUP.Add(step4IdTPS);
                postedStopMarketOrderIDUP.Add(step4IdSMS);

                executedStepUP = 4;
                Console.WriteLine("[BOT] step 4 up posted");

            }
        }

        // DOWN
        void BOTExecuteStep4DownIfContinueAndFilledStopMarketStep3Sell()
        {
            // if we are at up trade on 3rd step and stop market sell from 3rd step is filled
            if (continueWithUP && IsOrderWithIDFilled(step3IdSMS))
            {
                GlobalObjects.bitmex.DeleteOrder(Step1IdTPS);
                step4IdTPB = BotApiCalls.PlaceStep4TakeProfitBuyOrder(GetOrderWithID( step3IdSMS));
                step4IdSMB = BotApiCalls.PlaceStep4StopMarketBuyOrder(GetOrderWithID( step3IdSMS));
                postedTakeProfitOrdersIDDown.Add(step4IdTPB);
                postedStopMarketOrderIDDown.Add(step4IdSMB);
                executedStepDown = 4;
                Console.WriteLine("[BOT] step 4 down posted");

            }
        }





        void BOTCandleExecuteStep1UpAndDown()
        {
            Step1();
            Thread.Sleep(500);
            if (IsOrderWithIDFilled(Step1IdTPS))
            {
  
                // if we TakeProfit from up trade on Step1 we stop the bot
                continueWithUP = false;
                Console.WriteLine("[BOT]  continueWithUP = false;");
            }
            if (IsOrderWithIDFilled(Step1IdTPB))
            {
                // if we TakeProfit from down trade on Step1 we stop the bot
                continueWithDown = false;
                Console.WriteLine("[BOT]  continueWithDown = false;");
            }
        }


        void CheckTakeProfitUPAndSetVariables()
        {
            foreach (var item in postedTakeProfitOrdersIDUP.ToList())
            {
                if (IsOrderWithIDFilled(item))
                {
                    continueWithUP = false;
                    Console.WriteLine("[BOT] CheckTakeProfitUPAndSetVariables + continueWithUP = false ");
                    foreach (var it in postedStopMarketOrderIDUP.ToList())
                    {
                        GlobalObjects.bitmex.DeleteOrder(it);
                        postedStopMarketOrderIDUP.Remove(it);

                    }

                }
            }
        }
        void CheckTakeProfitDownAndSetVariables()
        {
            foreach (var item in postedTakeProfitOrdersIDDown.ToList())
            {
                if (IsOrderWithIDFilled(item))
                {
                    continueWithDown = false;
                    Console.WriteLine("[BOT] CheckTakeProfitDownAndSetVariables + continueWithDown = false ");
                    foreach (var it in postedStopMarketOrderIDDown.ToList())
                    {
                        GlobalObjects.bitmex.DeleteOrder(it);
                        postedStopMarketOrderIDDown.Remove(it);

                    }

                }
            }
        }

        public void Excecute()
        {
            async void logic()
            {

                while (GlobalObjects.isRunning)
                {

                    Thread.Sleep(500);


                    // bitmex.getOpenPositions must be from sockets
                    // but we are not making so many requests

                    botDataTime = DateTime.Now;
                    bool areWeAM = (string.Compare(botDataTime.ToString("tt"), "AM") == 0);
                    if (areWeAM && tradeTime == 2)
                    {

                        // if we are morning and were trading at last afternoon
                        if (continueWithDown == false && continueWithUP == false && GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count == 0)
                        {

                            // if we take profit from up and down we null the bot and start trading again
                            NULLBOT();

                            Thread.Sleep(50);
                        }

                        bool deleteDown = false;
                        bool deleteUp = false;
                        foreach (var item in postedStopMarketOrderIDDown)
                        {
                            if (String.Compare(GlobalObjects.lastOrders[item].OrdStatus, "filled") == 0 && continueWithDown && GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count != 0)
                            {
                                deleteDown = true;
                            }

                        }

                        foreach (var item in postedStopMarketOrderIDUP)
                        {
                            if (String.Compare(GlobalObjects.lastOrders[item].OrdStatus, "filled") == 0 && continueWithUP && GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count != 0)
                            {
                                deleteUp = true;
                            }

                        }

                        if (deleteUp && continueWithUP)
                        {
                            foreach (var item in postedStopMarketOrderIDUP.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedStopMarketOrderIDUP.Remove(item);
                            }

                            foreach (var item in postedTakeProfitOrdersIDUP.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedTakeProfitOrdersIDUP.Remove(item);
                            }

                        }
                        if (deleteDown && continueWithDown)
                        {
                            foreach (var item in postedStopMarketOrderIDDown.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedStopMarketOrderIDDown.Remove(item);
                            }
                            foreach (var item in postedTakeProfitOrdersIDDown.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedTakeProfitOrdersIDDown.Remove(item);
                            }


                        }


                    }
                    if (areWeAM == false && tradeTime == 1)
                    {
                        //if we are not morning and we were trading at morning
                        if (continueWithDown == false && continueWithUP == false && GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count == 0)
                        {
                            // if we have taken profit from up and down we null the bot
                            NULLBOT();
                            Thread.Sleep(50);

                        }
                        bool deleteDown2 = false;
                        bool deleteUp2 = false;
                        foreach (var item in postedStopMarketOrderIDDown)
                        {
                            if (String.Compare(GlobalObjects.lastOrders[item].OrdStatus, "filled") == 0 && continueWithDown && GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count != 0)
                            {
                                deleteUp2 = true;

                            }
                        }
                        foreach (var item in postedStopMarketOrderIDUP)
                        {
                            if (String.Compare(GlobalObjects.lastOrders[item].OrdStatus, "filled") == 0 && continueWithUP && GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count != 0)
                            {
                                deleteDown2 = true;

                            }
                        }
                        if (deleteUp2 && continueWithUP)
                        {
                            foreach (var item in postedStopMarketOrderIDUP.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedStopMarketOrderIDUP.Remove(item);
                            }
                            foreach (var item in postedTakeProfitOrdersIDUP.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedTakeProfitOrdersIDUP.Remove(item);
                            }


                        }
                        if (deleteDown2 && continueWithDown)
                        {
                            foreach (var item in postedStopMarketOrderIDDown.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedStopMarketOrderIDDown.Remove(item);
                            }
                            foreach (var item in postedTakeProfitOrdersIDDown.ToList())
                            {
                                GlobalObjects.bitmex.DeleteOrder(item);
                                postedTakeProfitOrdersIDDown.Remove(item);
                            }


                        }
                    }
                    // if we do not have open position from the last candle we null the bot
                    if (areWeAM && tradeTime == 2)
                    {
                        if (GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count == 0)
                        {
                            GlobalObjects.bitmex.CancelAllOpenOrders(GlobalObjects.activeInstrument.Symbol);
                            NULLBOT();

                            Thread.Sleep(50);
                        }
                    }
                    if (areWeAM == false && tradeTime == 1)
                    {
                        if (GlobalObjects.bitmex.GetOpenPositions(GlobalObjects.activeInstrument.Symbol).Count == 0)
                        {
                            GlobalObjects.bitmex.CancelAllOpenOrders(GlobalObjects.activeInstrument.Symbol);
                            NULLBOT();

                            Thread.Sleep(50);
                        }
                    }



                    if (continueWithUP)
                    {
                        switch (executedStepUP)
                        {
                            case 0: BOTCandleExecuteStep1UpAndDown(); break;

                            case 1:

                                CheckTakeProfitUPAndSetVariables(); ; CheckTakeProfitDownAndSetVariables();

                                BOTExecuteStep2UPIfContiNueAndFilledStopMarketStep1BUY();


                                break;
                            case 2:

                                CheckTakeProfitUPAndSetVariables(); CheckTakeProfitDownAndSetVariables();

                                BOTExecuteStep3UPIfContinueAndFilledStopMarketStep2Sell();
                                break;
                            case 3:
                                CheckTakeProfitUPAndSetVariables(); CheckTakeProfitDownAndSetVariables();
                                BOTExecuteStep4UPIfContinueAndFilledStopMarketStep3Buy(); break;
                            case 4:
                                if (string.Compare(GlobalObjects.lastOrders[step4IdSMS].OrdStatus, "Filled") == 0)
                                {
                                    GlobalObjects.bitmex.DeleteOrder(step4IdTPS);
                                    continueWithUP = false;

                                }

                                break;


                            default:
                                if (upOnce)
                                {
                                    // we succesfuly finished up trade logic
                                    upOnce = false;
                                }

                                break;
                        }
                    }
                    if (continueWithDown)
                    {
                        switch (executedStepDown)
                        {
                            case 0: BOTCandleExecuteStep1UpAndDown(); break;

                            case 1:
                                CheckTakeProfitUPAndSetVariables(); CheckTakeProfitDownAndSetVariables();

                                BOTExecuteStep2DownIfContinueAndFilledStopMarketStep1SELL();
                                break;
                            case 2:

                                CheckTakeProfitUPAndSetVariables(); CheckTakeProfitDownAndSetVariables();
                                BOTExecuteStep3DownIfContinueAndFilledStopMarketStep2Buy();

                                break;
                            case 3:
                                CheckTakeProfitUPAndSetVariables(); CheckTakeProfitDownAndSetVariables();
                                BOTExecuteStep4DownIfContinueAndFilledStopMarketStep3Sell();

                                break;
                            case 4:
                                if (string.Compare(GlobalObjects.lastOrders[step4IdSMB].OrdStatus, "Filled") == 0)
                                {
                                    GlobalObjects.bitmex.DeleteOrder(step4IdTPB);
                                    continueWithDown = false;
                                }

                                break;
                            default:

                                if (downOnce)
                                {
                                    // we successfully finished down trade logic
                                    downOnce = false;
                                }

                                break;
                        }
                    }
                }


            }
            Task.Run(logic);
        }


        public void NULLBOT()
        {

            /*
             
             
                if (wasItRunning)
                {
                    continueWithUP = true;
                    executedStepUP = 0;
                    continueWithDown = true;
                    executedStepDown = 0;
                    postedTakeProfitOrdersIDUP.Clear();
                    postedTakeProfitOrdersIDDown.Clear();
                    wasItRunning = false;
                }
             
             
             */
            GlobalObjects.candles.Clear();
            GlobalObjects.listof12Candles.Clear();


            GlobalObjects.one12HoursCandle.Clear();

            GlobalObjects.lastOrders.Clear();
            GlobalObjects.openPositions.Clear();

            // up
            continueWithUP = true;
            executedStepUP = 0;
            postedTakeProfitOrdersIDUP.Clear();
            postedStopMarketOrderIDUP.Clear();
            // down
            continueWithDown = true;
            executedStepDown = 0;
            postedTakeProfitOrdersIDDown.Clear();
            postedStopMarketOrderIDDown.Clear();
            GlobalObjects.isRunning = false;
            Step1IdSMB = "";
            Step1IdTPS = "";
            Step1IdSMS = "";
            Step1IdTPB = "";
            // step 2
            step2IdSMS = "";
            step2IdSMB = "";
            // step 3
            // up
            step3IdTPB = "";
            step3IdSMB = "";
            step3IdTPS = "";
            step3IdSMS = "";
            // step4 
            step4IdSMS = "";
            step4IdTPS = "";
            step4IdSMB = "";
            step4IdTPB = "";


        }


        bool upOnce = true;
        bool downOnce = true;

        int tradeTime = 0;
        DateTime botDataTime = new DateTime();
        // if tradeTime = 1 we are trading at AM
        // if tradeTime = 2 we are trading at PM
        // if contonueWithUP == false && continueWithDown == false meands we open new candle

    }
}
