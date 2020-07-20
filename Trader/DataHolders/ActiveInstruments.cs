using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader
{
    class ActiveInstrument
    {
        private static ActiveInstrument instance = null;
        volatile private Instrument activeInstrument;
        volatile public List<Instrument> activeInstruments;
        BitmexApiConnector bitmex;

        private ActiveInstrument()
        {
            activeInstrument = new Instrument();
            activeInstruments = new List<Instrument>();
            bitmex = BitmexApiConnector.Instance;
        }

        public static ActiveInstrument Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ActiveInstrument();
                }

                return instance;
            }
        }
        public string ActiveSymbol
        {
            get { return this.activeInstrument.Symbol.ToString(); }
        }
        public void ChangeActiveInstrument(string _symbol)
        {
            activeInstrument = bitmex.GetInstrument(_symbol)[0];
        }
        public List<Instrument> GetInstruments()
        {
            List<Instrument> result = new List<Instrument>(activeInstruments);
            return result;

        }
        public void RequestActiveInstruments()
        {
            activeInstruments = bitmex.GetActiveInstruments().OrderByDescending(a => a.Volume24H).ToList();
        }


    }
}
