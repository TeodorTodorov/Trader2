using System;

namespace Trader
{
    public class BitmexApiConnector
    {
        private string domain = "https://bitmex.com";
        private string apiKey;
        private string apiSecret;
        private int rateLimit;
        public int afterLogFileSleepMilisecs = 60;

        public BitmexApiConnector()
        {

        }

    }
}