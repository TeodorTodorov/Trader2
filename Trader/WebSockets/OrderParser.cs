using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader.WebSockets
{
    static class OrderParser
    {
        public static bool Partial(JArray TD)
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

                if (GlobalObjects.lastOrders.ContainsKey(or.ClOrdID))
                {

                    GlobalObjects.lastOrders[or.ClOrdID] = or;

                }
                else
                {
                    GlobalObjects.lastOrders.Add(or.ClOrdID, or);
                }

            }
            return true;

        }

        public static bool Update(JArray TD)
        {
            if (!TD.Any())
            {
                Console.WriteLine("no update data");
                return false;
            }

            foreach (JObject item in TD)
            {
                string clOrdID = item["clOrdID"].ToString();
                if (GlobalObjects.lastOrders.ContainsKey(clOrdID))
                {

                    GlobalObjects.lastOrders[clOrdID].Symbol = item["symbol"].ToString();


                    if (item.ContainsKey("stopPx"))
                    {
                        GlobalObjects.lastOrders[clOrdID].StopPx = item["stopPx"].ToString();
                    }
                    if (item.ContainsKey("ordStatus"))
                    {
                        GlobalObjects.lastOrders[clOrdID].OrdStatus = item["ordStatus"].ToString();

                    }

                    if (item.ContainsKey("orderQty"))
                    {
                        GlobalObjects.lastOrders[clOrdID].OrderQty = Int32.Parse(item["orderQty"].ToString());
                    }



                }
                else
                {
                    Console.WriteLine("[ERROR] tried to update not existing order with ClorID:" + item["clOrdID"].ToString());
                    return false;
                }
            }
            return true;

        }

        public static bool Insert(JArray TD)
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
                if (GlobalObjects.lastOrders.ContainsKey(or.ClOrdID))
                {

                    GlobalObjects.lastOrders[or.ClOrdID] = or;


                }
                else
                {
                    GlobalObjects.lastOrders.Add(or.ClOrdID, or);

                }
            }
            return true;
        }

    }
}
