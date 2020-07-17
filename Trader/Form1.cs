using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trader;


namespace Trader
{
    public partial class Form1 : Form
    {
        readonly Bot bot;
        public static List<Candle> one12HoursCandle = new List<Candle>();
        readonly List<Order> testList = new List<Order>();

        public Form1()
        {
            Order or1 = new Order
            {
                OrderQty = 10,
                OrderId = "432"
            };
            testList.Add(or1);


            InitializeComponent();
            InitializeDropdownsAndSettings();
            InitializeAPI();
            InitializeSymbolInfromation();
            GlobalObjects.candleRetriever = new CandleRetriever();
            var source = new BindingSource(testList, null);



            System.Threading.Thread thread1 = new Thread(BSocket.HearthBeat);
            thread1.Start();

            //Action hearthbeat = () => BSocket.Hearthbeat();
            // Task task = Task.Run(hearthbeat);

            bot = new Bot();

        }

        private void InitializeDropdownsAndSettings()
        {

            nudStep1StopMarketBUYPRICE.Value = Properties.Settings.Default.Step1StopMarketBUYPRICE;
            nudStep1StopMarketSELLPRICE.Value = Properties.Settings.Default.Step1StopMarketSELLPRICE;
            nudStep1TakeProfitBUYPercent.Value = Properties.Settings.Default.Step1TakeProfitBUYPercent;
            nudStep2StopMarketSELLPercent.Value = Properties.Settings.Default.Step2StopMarketSELLPercent;
            nudStep2StopMarketBuyPercent.Value = Properties.Settings.Default.Step2StopMarketBuyPercent;
            nudStep3TakeProfitBUYPercent.Value = Properties.Settings.Default.Step3TakeProfitBUYPercent;
            nudStep3StopMarketBUYPercent.Value = Properties.Settings.Default.Step3StopMarketBUYPercent;
            nudStep3TakeProfitSELLPercent.Value = Properties.Settings.Default.Step3TakeProfitSELLPercent;
            nudStep3StopMarketSELLPercent.Value = Properties.Settings.Default.Step3StopMarketSELLPercent;

            nudStep4TakeProfitSELLPercent.Value = Properties.Settings.Default.Step4TakeProfitSELLPercent;
            nudStep4StopMarketSELLPercent.Value = Properties.Settings.Default.Step4StopMarketSELLPercent;
            nudStep4TakeProfitBUYPercent.Value = Properties.Settings.Default.Step4TakeProfitBUYPercent;
            nudStep4StopMarketBUYPercent.Value = Properties.Settings.Default.Step4StopMarketBUYPercent;

            nudSum.Value = Properties.Settings.Default.BOTstartQty;

            txtKey.Text = Properties.Settings.Default.key;
            txtSecret.Text = Properties.Settings.Default.secret;
            txtDomain.Text = Properties.Settings.Default.domain;
            txtSocket.Text = Properties.Settings.Default.socketDomain;





        }
        
        private void SaveDropDownAndSettings()
        {
            Properties.Settings.Default.Step1StopMarketBUYPRICE = nudStep1StopMarketBUYPRICE.Value;
            Properties.Settings.Default.Step1StopMarketSELLPRICE = nudStep1StopMarketSELLPRICE.Value;
            Properties.Settings.Default.Step1TakeProfitBUYPercent = nudStep1TakeProfitBUYPercent.Value;
            Properties.Settings.Default.Step2StopMarketSELLPercent = nudStep2StopMarketSELLPercent.Value;
            Properties.Settings.Default.Step2StopMarketBuyPercent = nudStep2StopMarketBuyPercent.Value;
            Properties.Settings.Default.Step3TakeProfitBUYPercent = nudStep3TakeProfitBUYPercent.Value;
            Properties.Settings.Default.Step3StopMarketBUYPercent = nudStep3StopMarketBUYPercent.Value;
            Properties.Settings.Default.Step3TakeProfitSELLPercent = nudStep3TakeProfitSELLPercent.Value;
            Properties.Settings.Default.Step3StopMarketSELLPercent = nudStep3StopMarketSELLPercent.Value;

            Properties.Settings.Default.Step4TakeProfitSELLPercent = nudStep4TakeProfitSELLPercent.Value;
            Properties.Settings.Default.Step4StopMarketSELLPercent = nudStep4StopMarketSELLPercent.Value;
            Properties.Settings.Default.Step4TakeProfitBUYPercent = nudStep4TakeProfitBUYPercent.Value;
            Properties.Settings.Default.Step4StopMarketBUYPercent = nudStep4StopMarketBUYPercent.Value;
            Properties.Settings.Default.BOTstartQty = Convert.ToInt32(nudSum.Value);

            Properties.Settings.Default.key = txtKey.Text;
            Properties.Settings.Default.secret = txtSecret.Text;
            Properties.Settings.Default.domain = txtDomain.Text;
            Properties.Settings.Default.socketDomain = txtSocket.Text;
            Properties.Settings.Default.Save();
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveDropDownAndSettings();
        }
        private void InitializeAPI()
        {
            GlobalObjects.bitmex = new BitmexApiConnector(Properties.Settings.Default.key, Properties.Settings.Default.secret, Properties.Settings.Default.domain);

            // We must do this in case symbols are different on test and real net
            // GetAPIValidity(); // Validate API keys by checking and displaying account balance.
            // InitializeSymbolInformation();
            InitializeSymbolInfromation();
        }



        private void BtnStartBot_Click(object sender, EventArgs e)
        {
            if (!GlobalObjects.isRunning)
            {

                btnStartBot.BackColor = Color.Red;
                GlobalObjects.isRunning = true;
                btnStartBot.Text = "Bot is running";
                btnStopBot.BackColor = Color.Green;
                GlobalObjects.isRunning = true;
                bot.Excecute();

            }
        }
        private void BtnStopBot_Click(object sender, EventArgs e)
        {

            if (GlobalObjects.isRunning)
            {
                GlobalObjects.isRunning = false; // to start and stop the bot
                bot.NULLBOT();
                bot.continueWithUP = true;
                bot.executedStepUP = 0;
                bot.continueWithDown = true;
                bot.executedStepDown = 0;
                bot.postedTakeProfitOrdersIDUP.Clear();
                bot.postedTakeProfitOrdersIDDown.Clear();
                GlobalObjects.isRunning = false;
                btnStopBot.BackColor = Color.Red;
                btnStartBot.Text = "Start Bot";
                btnStartBot.BackColor = Color.Green;

            }


        }


        private void InitializeSymbolInfromation()
        {
            GlobalObjects.ActiveInstruments = GlobalObjects.bitmex.GetActiveInstruments().OrderByDescending(a => a.Volume24H).ToList();
            ddlSymbol.DataSource = GlobalObjects.ActiveInstruments;
            ddlSymbol.DisplayMember = "Symbol";
            ddlSymbol.SelectedIndex = 0;
            GlobalObjects.ActiveInstrument = GlobalObjects.ActiveInstruments[0];
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveDropDownAndSettings();
        }
        private void DdlSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalObjects.ActiveInstrument = GlobalObjects.bitmex.GetInstrument(((Instrument)ddlSymbol.SelectedItem).Symbol)[0];
        }

        private void BtnPing_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            List<Order> orders = GlobalObjects.lastOrders.Values.ToList();
            SocketGetOrders.DataSource = orders;
            Console.WriteLine(orders.Count);
            Console.WriteLine(GlobalObjects.lastOrders.Count);
            foreach (var item in orders)
            {

                Console.WriteLine(item.ClOrdID + " " + item.StopPx);
            }


        }

        private void Refrest12CandlesGrid_Click(object sender, EventArgs e)
        {
            dataGridCandles.DataSource = GlobalObjects.listof12Candles.ToList<Candle>();
            dataGrind12Hour.DataSource = GlobalObjects.one12HoursCandle.ToList<Candle>();
        }

        private void BtnDeleteByClorID_Click(object sender, EventArgs e)
        {
            string clorid = txtDeleteByClorid.Text;
            GlobalObjects.bitmex.DeleteOrder(clorid);
        }
    }

}


