using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace Trader.WebSockets
{
    public class OrderParser
    {
        OrdersOnlineDTO ordersDTO;
        public OrderParser(OrdersOnlineDTO _ordersDTO)
        {
            this.ordersDTO = _ordersDTO;
        }
        public bool Partial(JArray TD)
        {
            if (!TD.Any())
            {
                Console.WriteLine("no partial data");
                return false;
            }

            foreach (JObject item in TD)
            {
                Order or = new Order
                {
                    Symbol = item["symbol"].ToString(),
                    OrderQty = Convert.ToInt32(item["orderQty"].ToString()),
                    ClOrdID = item["clOrdID"].ToString(),
                    Side = item["side"].ToString(),
                    StopPx = item["stopPx"].ToString(),
                    OrdStatus = item["ordStatus"].ToString(),
                    OrderId = item["orderID"].ToString()
                };
                this.ordersDTO.TryInsertReplace(or);



            }
            return true;

        }

        public bool Update(JArray TD)
        {
            if (!TD.Any())
            {
                Console.WriteLine("no update data");
                return false;
            }
            bool success = true;

            foreach (JObject item in TD)
            {
                string clOrdID = item["clOrdID"].ToString();
                string stopPx = null;
                string ordStatus = null;
                int? orderQty = null;
                if (item.ContainsKey("stopPx"))
                {
                    stopPx = item["stopPx"].ToString();
                }
                if (item.ContainsKey("ordStatus"))
                {
                    ordStatus = item["ordStatus"].ToString();
                }

                if (item.ContainsKey("orderQty"))
                {
                    orderQty = Convert.ToInt32(item["orderQty"].ToString());
                }
               bool res =  this.ordersDTO.TryUpdate(clOrdID, stopPx, ordStatus, orderQty);
                if (success = true && res == false)
                {
                    success = res;
                }
            }
            return success;
        }



        public bool Insert(JArray TD)
        {
            if (!TD.Any())
            {
                Console.WriteLine("no insert data");
                return false;
            }

            foreach (JObject item in TD)
            {
                Order or = new Order
                {
                    Symbol = item["symbol"].ToString()
                };
                if (String.Compare(item["orderQty"].ToString(), "") != 0)
                {
                    or.OrderQty = Convert.ToInt32(item["orderQty"].ToString());
                }
                if (String.Compare(item["clOrdID"].ToString(), "") != 0L)
                {
                    or.ClOrdID = item["clOrdID"].ToString();
                }
                if (String.Compare(item["side"].ToString(), "") != 0)
                {
                    or.Side = item["side"].ToString();
                }
                if (String.Compare(item["stopPx"].ToString(), "") != 0)
                {
                    or.StopPx = item["stopPx"].ToString();
                }
                if (String.Compare(item["ordStatus"].ToString(), "") != 0)
                {
                    or.OrdStatus = item["ordStatus"].ToString();
                }
                if (String.Compare(item["orderID"].ToString(), "") != 0)
                {
                    or.OrderId = item["orderID"].ToString();
                }
                if (or.ClOrdID == null)
                {
                    Console.WriteLine("[ERROR] insert oder cLOrdID is null");
                }
                this.ordersDTO.TryInsertReplace(or);
            }
            return true;
        }

    }
}
