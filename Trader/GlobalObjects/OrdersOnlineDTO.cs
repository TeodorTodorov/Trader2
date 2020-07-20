using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Trader
{
    public class OrdersOnlineDTO
    {
       public volatile ConcurrentDictionary<string, Order> dictionary;
        public volatile List<Order> orderList;
        OrdersOnlineSubject subject;
        private void UpdateList()
        {
            orderList = dictionary.Values.ToList();
        }
        public OrdersOnlineDTO(OrdersOnlineSubject _subject)
        {
            dictionary = new ConcurrentDictionary<string, Order>();
            this.subject = _subject;
        }
        public bool TryInsertReplace(Order o)
        {
            Console.WriteLine("inserreplace");
            bool success = false;
            if (dictionary.ContainsKey(o.ClOrdID))
            {
                this.dictionary[o.ClOrdID] = o;
                success = true;
            }
            else
            {
                success = this.dictionary.TryAdd(o.ClOrdID, o);

            }
            if (success)
            {
                UpdateList();
                this.subject.Changed(this);

            }
            return success;
        }



        public bool TryUpdate(string _clorid, string _stopPx, string _ordStatus, int? _orderQty)
        {
            if (this.dictionary.ContainsKey(_clorid))
            {
                Order or = this.dictionary[_clorid];
                if (_stopPx != null)
                {
                    or.StopPx = _stopPx;
                }
                if (_ordStatus != null) 
                {
                    or.OrdStatus = _ordStatus;
                }
                if (_orderQty != null)
                {
                    or.OrderQty = _orderQty;
                }
                this.dictionary[_clorid] = or;
                this.subject.Changed(this);
                UpdateList();
                return true;
            }
            return false;
        }
        public bool IsIn(string key)
        {
            return dictionary.ContainsKey(key);
        }
        public Order GetByClorId(string key)
        {
            return this.dictionary[key];
        }
        public  ConcurrentDictionary<string, Order> GetDictionary()
        {
            return this.dictionary;
        }
    }
}
