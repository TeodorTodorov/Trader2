using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader
{
    public class OrdersOnlineSubject : IObservable<OrdersOnlineDTO>
    {
        private List<IObserver<OrdersOnlineDTO>> observers = new List<IObserver<OrdersOnlineDTO>>();
        public IDisposable Subscribe(IObserver<OrdersOnlineDTO> observer)
        {
            observers.Add(observer);
            // this is IDisposible which is called when dispose is called
            return new Unsubscriber(observers, observer);
        }
        public void Changed(OrdersOnlineDTO dictionary)
        {
            foreach (var item in observers)
            {
                item.OnNext(dictionary);
            }
        }
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<OrdersOnlineDTO>> _observers;
            private IObserver<OrdersOnlineDTO> _observer;
            public Unsubscriber(List<IObserver<OrdersOnlineDTO>> observers, IObserver<OrdersOnlineDTO> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }
            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }


    }
}
