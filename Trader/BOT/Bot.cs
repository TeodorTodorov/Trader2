
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
using System.Windows.Markup;

namespace Trader
{
    class Bot : IObserver<OrdersOnlineDTO>
    {
        private volatile CandleRetriever candleRetriever;
        private volatile BitmexApiConnector bitmex;
        volatile BotApiCalls botApiCalls;
        volatile OrdersOnlineDTO orderDTO;
        volatile Dictionary<int, string> sucessfullOrders;
        volatile int stepUP;
        volatile int stepDOWN;
        volatile bool isUpTrading;
        volatile bool isDownTrading;
        volatile SemaphoreSlim semaphoreSlim;

        public Bot(OrdersOnlineDTO _orderDTO)
        {
            bitmex = BitmexApiConnector.Instance;
            candleRetriever = CandleRetriever.Instance;
            botApiCalls = BotApiCalls.Instance;
            this.orderDTO = _orderDTO;
            sucessfullOrders = new Dictionary<int, String>();
            stepDOWN = 0;
            stepUP = 0;
            isUpTrading = false;
            isDownTrading = false;
            semaphoreSlim = new SemaphoreSlim(1, 1);
        }
        public void Start()
        {
            isUpTrading = true;
            isDownTrading = true;
            TickOnce();
        }
        public void PauseStop()
        {
            isUpTrading = false;
            isDownTrading = false;
        }
        public void PauseResume()
        {
            isUpTrading = true;
            isDownTrading = true;
            TickOnce();
        }
        public async void  TickOnce()
        {
            await semaphoreSlim.WaitAsync();
            try
            {
                await Task.Run(() =>
                {
                    Console.WriteLine();
                    Console.WriteLine("RUN bot thread-------------------------------------------------");
                    Console.WriteLine();
                    Tick();
                    Console.WriteLine();
                    Console.WriteLine("RUN bot thread finised--------------------------");
                    Console.WriteLine();
                });
            }
            finally
            {
                //When the task is ready, release the semaphore. It is vital to ALWAYS release the semaphore when we are ready, or else we will end up with a Semaphore that is forever locked.
                //This is why it is important to do the Release within a try...finally clause; program execution may crash or take a different path, this way you are guaranteed execution
                semaphoreSlim.Release();
                Console.WriteLine();
                Console.WriteLine("SEMAPHORE RELEASED-------------------");
                Console.WriteLine();
            }
          
        }
        void Tick()
        {
            Console.WriteLine("Tick runned");
            if (isUpTrading)
            {
                this.TickUP();
            }
            if (isDownTrading)
            {
                this.TickDOWN();
            }
        }
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(OrdersOnlineDTO _value)
        {
            orderDTO = _value;
            TickOnce();
        }

        void TickUP()
        {
            switch (stepUP)
            {
                case 0: Step1UP(); break;
                case 1:
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[1]).OrdStatus, "Filled") == 0)
                    {
                        Step2UP();
                    }; break;
                case 2:
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[2]).OrdStatus, "Filled") == 0)
                    {
                        Step3UPOrder2Filled();
                    }
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[3]).OrdStatus, "Filled") == 0 || string.Compare(orderDTO.GetByClorId(sucessfullOrders[4]).OrdStatus, "Filled") == 0)
                    {
                        Step3UPOrder3or4Filled();
                    }; break;
                case 3:
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[5]).OrdStatus, "Filled") == 0)
                    {
                        Step4UPOrder5Filled();
                    }
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[6]).OrdStatus, "Filled") == 0)
                    {
                        Step4UPOrder6Filled();
                    }; break;

                default: throw new Exception("Error stepUp case, values:" + stepUP);

            }
            
        }
        void TickDOWN()
        {
            switch (stepDOWN)
            {
                case 0: Step1DOWN(); break;
                case 1:
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[7]).OrdStatus, "Filled") == 0)
                    {
                        Step2DOWN();
                    }; break;
                case 2:
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[8]).OrdStatus, "Filled") == 0)
                    {
                        Step3DOWNOrder8Filled();
                    }
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[9]).OrdStatus, "Filled") == 0 || string.Compare(orderDTO.GetByClorId(sucessfullOrders[10]).OrdStatus, "Filled") == 0)
                    {
                        Step3DOWNOrder9or10Filled();
                    }; break;
                case 3:
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[11]).OrdStatus, "Filled") == 0)
                    {
                        Step4DOWNOrder11Filled();
                    }
                    if (string.Compare(orderDTO.GetByClorId(sucessfullOrders[12]).OrdStatus, "Filled") == 0)
                    {
                        Step4DOWNOrder12Filled();
                    }
                    ; break;

                default:
                    throw new Exception("Error stepDOWN case, values:" + stepDOWN);

            }
        }

        void Step1UP()
        {
            sucessfullOrders[1] = botApiCalls.Step1UP();
            stepUP = 1;
        }
        void Step1DOWN()
        {
            sucessfullOrders[7] = botApiCalls.Step1DOWN();
            stepDOWN = 1;
        }
        void Step2UP()
        {
            Order order1 = orderDTO.GetByClorId(sucessfullOrders[1]);
            sucessfullOrders[2] = botApiCalls.Step2Order2(order1);
            sucessfullOrders[3] = botApiCalls.Step2Order3(order1);
            sucessfullOrders[4] = botApiCalls.Step2Order4(order1);
            stepUP = 2;
        }

        void Step3UPOrder2Filled()
        {
            // stop the up trading !
            isUpTrading = false;
            bitmex.DeleteOrder(sucessfullOrders[3]);
            bitmex.DeleteOrder(sucessfullOrders[4]);
        }
        void Step3UPOrder3or4Filled()
        {
            Order order4 = orderDTO.GetByClorId(sucessfullOrders[4]);
            bitmex.DeleteOrder(sucessfullOrders[2]);
            sucessfullOrders[5] = botApiCalls.Step3Order5(order4);
            sucessfullOrders[6] = botApiCalls.Step3Order6(order4);
            stepUP = 3;
        }
        void Step4UPOrder5Filled()
        {
            // stop the up trading !
            isUpTrading = false;
            bitmex.DeleteOrder(sucessfullOrders[6]);
        }
        void Step4UPOrder6Filled()
        {
            // stop the up trading !
            isUpTrading = false;
            bitmex.DeleteOrder(sucessfullOrders[5]);

        }
        void Step2DOWN()
        {
            Order order7 = orderDTO.GetByClorId(sucessfullOrders[7]);
            sucessfullOrders[8] = botApiCalls.Step2Order8(order7);
            sucessfullOrders[9] = botApiCalls.Step2Order9(order7);
            sucessfullOrders[10] = botApiCalls.Step2Order10(order7);
            stepDOWN = 2;
        }
        void Step3DOWNOrder8Filled()
        {
            // stop the down trading !
            isDownTrading = false;
            bitmex.DeleteOrder(sucessfullOrders[9]);
            bitmex.DeleteOrder(sucessfullOrders[10]);
        }
        void Step3DOWNOrder9or10Filled()
        {
            Order order9 = orderDTO.GetByClorId(sucessfullOrders[9]);
            bitmex.DeleteOrder(sucessfullOrders[8]);
            sucessfullOrders[11] = botApiCalls.Step3Order5(order9);
            sucessfullOrders[12] = botApiCalls.Step3Order6(order9);
            stepDOWN = 3;
        }
        void Step4DOWNOrder11Filled()
        {
            // stop the down trading !
            isDownTrading = false;
            bitmex.DeleteOrder(sucessfullOrders[12]);
        }
        void Step4DOWNOrder12Filled()
        {
            // stop the down trading !
            isDownTrading = false;
            bitmex.DeleteOrder(sucessfullOrders[11]);

        }
    }

}

