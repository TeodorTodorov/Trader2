using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trader
{
    class OrdersOnlineSubscriber : IObserver<OrdersOnlineDTO>
    {
        private DataGridView dg;
        List<Order> ls;
       public  OrdersOnlineSubscriber(DataGridView _dg)
        {
            dg = _dg;
        }
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(OrdersOnlineDTO dto)
        {
            Console.WriteLine("UPDATEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
           ls = dto.GetDictionary().Values.ToList();
            foreach (var item in ls)
            {
                Console.WriteLine(item.ToString());
            }
            dg.Invoke(new MethodInvoker(() => dg.DataSource = dto.orderList));
                

        }
    }
}
