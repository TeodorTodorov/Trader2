using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using WebSocketSharp;
using Newtonsoft.Json.Linq;
using System.Threading;
using Trader.Cryptography;
using Trader.WebSockets;
using System.Drawing.Text;
using System.IO;

namespace Trader
{
    public class BSocket
    {
        private readonly string apiKey = Properties.Settings.Default.key ?? "";
        private readonly string apiSecret = Properties.Settings.Default.secret ?? "";
        private readonly string bitmexURL = Properties.Settings.Default.socketDomain ?? "wss://www.bitmex.com/realtime";
        volatile private int counter = 5;
        volatile private WebSocket ws;
        private WebSocket socket;
        public OrderParser orderParser;

        private void Timer_Tick(object sender, EventArgs e)
        {
            ws.Send("ping");
            socket.Send("ping");
            Console.WriteLine("[Sockets pinged]");
            counter--;
        }

        private string GetExpiresArg()
        {
            long timestamp = (long)((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);

            string expires = (timestamp + 1000000).ToString();
            // timestamp + 10 before

            return (expires);
        }

        private string GetWebSocketSignatureString(string APISecret, string APIExpires)
        {
            byte[] signatureBytes = Encryptor.Hmacsha256(Encoding.UTF8.GetBytes(APISecret), Encoding.UTF8.GetBytes("GET/realtime" + APIExpires));
            string signatureString = Encryptor.ByteArrayToString(signatureBytes);
            return signatureString;
        }

        private void Authenticate()
        {
            // Authenticate the socket
            string APIExpires = GetExpiresArg();
            string Signature = GetWebSocketSignatureString(apiSecret, APIExpires);
            SendRequest("{\"op\": \"authKeyExpires\", \"args\": [\"" + apiKey + "\", " + APIExpires + ", \"" + Signature + "\"]}");
            SendRequest("{\"op\": \"subscribe\", \"args\": [\"order\"]}");
        }

        private void MessageHandle(object sender, MessageEventArgs e)
        {
            try
            {
                if (e.Data.Contains("pong"))
                {
                    Console.WriteLine("[Socket Info pong]");
                    return;
                }

                Console.WriteLine("[MESSAGE]");
                Console.WriteLine(sender.ToString());
                Console.WriteLine(e.Data.ToString());
                Console.WriteLine(e.ToString());
                Console.WriteLine();

                JObject Message = JObject.Parse(e.Data);

                if (Message.ContainsKey("info") && Message.ContainsKey("docs"))
                {
                    string WebSocketInfo = "Websocket Info: " + Message["info"].ToString() + " " + Message["docs"].ToString();
                    Console.WriteLine("[INFO]");
                    Console.WriteLine(WebSocketInfo);
                }
                else if (Message.ContainsKey("table") && (string)Message["table"] == "order")
                {
                    Console.WriteLine(Message.ToString());
                    string action = Message.GetValue("action").ToString();

                    JArray TD = (JArray)Message["data"];

                    if (string.Compare(action, "partial") == 0)
                    {
                        orderParser.Partial(TD);
                    }
                    else if (string.Compare(action, "update") == 0)
                    {
                        orderParser.Update(TD);
                    }
                    else if (string.Compare(action, "insert") == 0)
                    {
                        orderParser.Insert(TD);
                    }
                }
                else
                {
                    Console.WriteLine("[ERROR] not parsed message");
                    Console.WriteLine(Message.ToString());
                    Console.WriteLine("[ERROR] not parsed message closes here");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("[EXCEPTION]");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Data.ToString());
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);

            }
        }

        private void OpenHandle(object sender, EventArgs e)
        {
            Console.WriteLine("[SOCKET Info opened]");
            Console.WriteLine(e.ToString());
        }

        private void ErrorHandle(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            Console.WriteLine("[Error]");
            Console.WriteLine(e.Message);
        }

        private void CloseHandle(object sender, WebSocketSharp.CloseEventArgs e)
        {
            Console.WriteLine("[SOCKET INFO closed]");
        }
        public BSocket(OrderParser _orderParser)
        {
            orderParser = _orderParser;
        }

        public void InitWebSocket()
        {

            socket = new WebSocket(bitmexURL);
            try
            {
                socket.Connect();
            }
            catch (Exception sock)
            {
                Console.WriteLine(sock.Message);
            }

            Authenticate();
            socket.OnOpen += OpenHandle;
            socket.OnMessage += MessageHandle;
            socket.OnError += ErrorHandle;
            socket.OnClose += CloseHandle;
        }

        public void HearthBeat()
        {

            System.Timers.Timer timer1 = new System.Timers.Timer(5000);

            timer1.Elapsed += Timer_Tick;
            timer1.AutoReset = true;


            ws = new WebSocket(bitmexURL);
            ws.OnOpen += (sender, e) =>
           {
               Console.WriteLine("[SOCKET Hearth opened]");
               Thread timerThread = new Thread(timer1.Start);
               counter = 5;
               timerThread.Start();
               InitWebSocket();

           };
            ws.OnMessage += (sender, e) =>
            {

                if (e.Data.Contains("pong"))
                {
                    Console.WriteLine("[Socket pong]");
                    counter = 5;
                }
            };
            ws.OnClose += (sender, e) =>
            {
                Console.WriteLine("[SOCKET Hearth closed]");
            };

            try
            {
                ws.Connect();

            }
            catch (Exception sock)
            {
                Console.WriteLine(sock.Message);
            }
            while (true)
            {

                if (counter < 0)
                {
                    timer1.Stop();
                    ws.Close();
                    socket.Close();
                    ws.Connect();


                }
            }
        }

        public void SendRequest(String request)
        {
            socket.Send(request);
        }
    }
}

