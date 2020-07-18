using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Trader;
using System.Runtime.Remoting.Channels;
using Trader.Cryptography;

namespace
    Trader
{
    public sealed class BitmexApiConnector
    {
        private readonly string domain;
        private readonly string apiKey;
        private readonly string apiSecret;
       
        //private static BitmexApiConnector instance = null;

        //private BitmexApiConnector()
        //{
        //}

        //public static BitmexApiConnector Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new BitmexApiConnector();
        //        }
        //        return instance;
        //    }
        //}

        public BitmexApiConnector(string bitmexKey = "", string bitmexSecret = "", string domain = "")
        {
            this.apiKey = bitmexKey;
            this.apiSecret = bitmexSecret;
          
            this.domain = domain;
            //  InitializeFileLoggers();
        }




        private long GetExpires()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 3600; // set expires one hour in the future
        }

        private string BuildQueryData(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            StringBuilder b = new StringBuilder();
            foreach (var item in param)
                b.Append(string.Format("&{0}={1}", item.Key, WebUtility.UrlEncode(item.Value)));

            try { return b.ToString().Substring(1); }
            catch (Exception) { return ""; }
        }
        public string GetWebSocketSignatureString(string APISecret, string APIExpires)
        {
            byte[] signatureBytes = Encryptor.Hmacsha256(Encoding.UTF8.GetBytes(APISecret), Encoding.UTF8.GetBytes("GET/realtime" + APIExpires));
            string signatureString = ByteArrayToString(signatureBytes);
            return signatureString;
        }
        private string BuildJSON(Dictionary<string, string> param)
        {
            if (param == null)
                return "";

            var entries = new List<string>();
            foreach (var item in param)
                entries.Add(string.Format("\"{0}\":\"{1}\"", item.Key, item.Value));

            return "{" + string.Join(",", entries) + "}";
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        private string Query(string method, string function, Dictionary<string, string> param = null, bool auth = false, bool json = false)
        {
            string paramData = json ? BuildJSON(param) : BuildQueryData(param);
            string url = "/api/v1" + function + ((method == "GET" && paramData != "") ? "?" + paramData : "");
            string postData = (method != "GET") ? paramData : "";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(domain + url);
            webRequest.Method = method;

            if (auth)
            {
                string expires = GetExpires().ToString();
                string message = method + url + expires + postData;
                byte[] signatureBytes = Encryptor.Hmacsha256(Encoding.UTF8.GetBytes(apiSecret), Encoding.UTF8.GetBytes(message));
                string signatureString = ByteArrayToString(signatureBytes);

                webRequest.Headers.Add("api-expires", expires);
                webRequest.Headers.Add("api-key", apiKey);
                webRequest.Headers.Add("api-signature", signatureString);
            }

            try
            {
                if (postData != "")
                {
                    webRequest.ContentType = json ? "application/json" : "application/x-www-form-urlencoded";
                    var data = Encoding.UTF8.GetBytes(postData);
                    using (var stream = webRequest.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }

                using (WebResponse webResponse = webRequest.GetResponse())
                using (Stream str = webResponse.GetResponseStream())
                using (StreamReader sr = new StreamReader(str))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (WebException wex)
            {
                using (HttpWebResponse response = (HttpWebResponse)wex.Response)
                {
                    if (response == null)
                        throw;

                    using (Stream str = response.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(str))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        public string GetExpiresArg()
        {
            long timestamp = (long)((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);

            string expires = (timestamp + 1000000).ToString();
            // timestamp + 10 before

            return (expires);
        }

        // CUSTOM Calls
        public List<OrderBook> GetOrderBook(string symbol, int depth)
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = symbol,
                ["depth"] = depth.ToString()
            };
            string res = Query("GET", "/orderBook/L2", param);
            return JsonConvert.DeserializeObject<List<OrderBook>>(res);
        }

        public string PostOrderPostOnly(string Symbol, string Side, double Price, int Quantity, string clOrdID)
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = Symbol,
                ["side"] = Side,
                ["orderQty"] = Quantity.ToString(),
                ["ordType"] = "Limit",
                ["execInst"] = "ParticipateDoNotInitiate",
                ["displayQty"] = 0.ToString(), // Shows the order as hidden, keeps us from moving price away from our own orders
                ["price"] = Price.ToString(),
                ["clOrdID"] = clOrdID
            };

            string res = Query("POST", "/order", param, true);
            Console.WriteLine(res);
            return res;
        }
        public string MarketOrder(string Symbol, string Side, int Quantity, string clOrdID)
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = Symbol,
                ["side"] = Side,
                ["orderQty"] = Quantity.ToString(),
                ["ordType"] = "Market",
                ["clOrdID"] = clOrdID
            };
            string res = Query("POST", "/order", param, true);
            Console.WriteLine(res);
            return res;
        }

        public string DeleteOrder(string clorId)
        {
            var param = new Dictionary<string, string>
            {
                ["clOrdID"] = clorId,
                ["text"] = "cancel order by clOrdID "
            };
            string res = Query("DELETE", "/order", param, true, true);
            Console.WriteLine(res);
            return res;
        }

        public string CancelAllOpenOrders(string symbol, string Note = "")
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = symbol,
                ["text"] = Note
            };
            string res = Query("DELETE", "/order/all", param, true, true);
            Console.WriteLine(res);
            return res;
        }

        public List<Instrument> GetActiveInstruments()
        {
            string res = Query("GET", "/instrument/active");
            return JsonConvert.DeserializeObject<List<Instrument>>(res);
        }

        public List<Instrument> GetInstrument(string symbol)
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = symbol
            };
            string res = Query("GET", "/instrument", param);
            return JsonConvert.DeserializeObject<List<Instrument>>(res);
        }

        //public List<Candle> GetCandleHistory(string symbol, int count, string size)
        //{
        //    var param = new Dictionary<string, string>();
        //    param["symbol"] = symbol;
        //    param["count"] = count.ToString();
        //    param["reverse"] = true.ToString(); // GETTING THE NEWEST CANDLES, not starting from the oldest
        //    param["partial"] = false.ToString(); // will return some incomplete candles (the now candle) we do not want incomplate values
        //    param["binSize"] = size;
        //    string res = Query("GET", "/trade/bucketId", param);
        //    return JsonConvert.DeserializeObject<List<Candle>>(res).OrderByDescending(a => a.TimeStamp).ToList();
        //    // should make shure the newest candle first sordet descending by timestamp


        //}

        public List<Candle> GetCandleHistory(string symbol, int count, string size)
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = symbol,
                ["count"] = count.ToString(),
                ["reverse"] = true.ToString(),
                ["partial"] = false.ToString(),
                ["binSize"] = size
            };
            int MaxRetries = 10;
            string res = Query("GET", "/trade/bucketed", param);
            int RetryAttemptCount = 0;


            while (res.Contains("error"))
            {
                // errors.Add(res);
                Thread.Sleep(100); // fort app to wait 500ms
                res = Query("GET", "/trade/bucketed", param);

                RetryAttemptCount++;
                if (RetryAttemptCount == MaxRetries)
                {
                    //  errors.Add("Max retry attempts of " + MaxRetries.ToString() + "reached.");

                    throw new Exception("max retry retry attempts of GetCandleHistory reaced" + res);

                }
            }

            return JsonConvert.DeserializeObject<List<Candle>>(res).OrderByDescending(a => a.TimeStamp).ToList();
        }

        public List<Position> GetOpenPositions(string symbol)
        {
            var param = new Dictionary<string, string>();
            string res = Query("GET", "/position", param, true);


            return JsonConvert.DeserializeObject<List<Position>>(res).Where(a => a.Symbol == symbol && a.IsOpen == true).OrderByDescending(a => a.TimeStamp).ToList();
        }

        public List<Order> GetOpenOrders(string symbol)
        {
            var param = new Dictionary<string, string>
            {
                ["symbol"] = symbol,
                ["reverse"] = true.ToString()
            };
            string res = Query("GET", "/order", param, true);
            return JsonConvert.DeserializeObject<List<Order>>(res).Where(a => a.OrdStatus == "New" || a.OrdStatus == "PartiallyFilled").OrderByDescending(a => a.TimeStamp).ToList();
        }
        //public List<Order> GetALLOrdersTedo(string symbol)
        //{
        //    var param = new Dictionary<string, string>();
        //    param["symbol"] = symbol;
        //    param["reverse"] = true.ToString();
        //    param["count"] = "10";
        //    // param["filter"] = ""
        //    string res = Query("GET", "/order", param, true);
        //    return JsonConvert.DeserializeObject<List<Order>>(res).Where(a => true).OrderByDescending(a => a.TimeStamp).ToList();

        //    // Try catch

        //}

        public string EditOrderPrice(string clOrdID, double Price)
        {
            var param = new Dictionary<string, string>
            {
                ["clOrdID"] = clOrdID,
                ["price"] = Price.ToString()
            };
            return Query("PUT", "/order", param, true, true);
        }

        public string MarketStop(string Symbol, string Side, double stopPrice, int Quantity, bool ReduceOnly, string clorID)
        {
            string text = "BMBStopMarket";
            string timeframe = "";
            var param = new Dictionary<string, string>
            {
                ["symbol"] = Symbol,
                ["side"] = Side,
                ["orderQty"] = Quantity.ToString(),
                ["stopPx"] = stopPrice.ToString(),
                ["ordType"] = "Stop",
                ["clOrdID"] = clorID,
                ["text"] = text + timeframe
            };

            if (ReduceOnly)
            {
                param["execInst"] = "ReduceOnly,LastPrice";
            }
            else
            {
                param["execInst"] = "LastPrice";
            }

            Console.WriteLine("[ORDER]MarketStop: " + "side: " + Side + "orderQty: " + Quantity.ToString() + "clOrdID: " + clorID + "stopPx: " + stopPrice.ToString());
            string res = Query("POST", "/order", param, true);

            Console.WriteLine("[SERVER RESPONSE]" + res);
            return res;
        }

        public string TakeProfitMarket(string Symbol, string Side, double stopPrice, int Quantity, bool ReduceOnly, string clorID)
        {
            string timeframe = "";
            string text = "BMBStopMarket";
            var param = new Dictionary<string, string>
            {
                ["symbol"] = Symbol,
                ["side"] = Side,
                ["orderQty"] = Quantity.ToString(),
                ["stopPx"] = stopPrice.ToString(),
                ["ordType"] = "MarketIfTouched",
                ["clOrdID"] = clorID,
                ["text"] = text + timeframe
            };
            if (ReduceOnly)
            {
                param["execInst"] = "ReduceOnly,LastPrice";
            }
            else
            {
                param["execInst"] = "LastPrice";
            }
            Console.WriteLine("[ORDER]marketstop: " + "side: " + Side + "orderQty: " + Quantity.ToString() + "clOrdID: " + clorID + "stopPx: " + stopPrice.ToString());
            string res = Query("POST", "/order", param, true);
            Console.WriteLine("[SERVER RESPONSE]" + res);
            return res;
        }

    }
}