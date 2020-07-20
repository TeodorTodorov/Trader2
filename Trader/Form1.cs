using System;
using System.Collections.Concurrent;
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

using Trader.WebSockets;

namespace Trader
{
    public partial class Form1 : Form
    {
        readonly Bot bot;
        OrdersOnlineDTO orderDTO;
        ActiveInstrument activeInstrument;
        BitmexApiConnector bitmex;
        List<Instrument> listInstruments;
        CandleRetriever candleRetriever;



        public Form1()
        {
            InitializeComponent();
            InitializeDropdownsAndSettings();
            InitializeAPI();
            InitializeSymbolInfromation();
            OrdersOnlineSubject orderSubject = new OrdersOnlineSubject();
            orderDTO = new OrdersOnlineDTO(orderSubject);
            OrderParser orderParser = new OrderParser(orderDTO);
            BSocket socket = new BSocket(orderParser);
            System.Threading.Thread thread1 = new Thread(socket.HearthBeat);
            OrdersOnlineSubscriber sb = new OrdersOnlineSubscriber(SocketGetOrders);
            SocketGetOrders.DataSource = orderDTO.orderList;
            candleRetriever = CandleRetriever.Instance;
            bot = new Bot(orderDTO);
            orderSubject.Subscribe(sb);
            orderSubject.Subscribe(bot);
            thread1.Start();
            //Action hearthbeat = () => BSocket.Hearthbeat();
            // Task task = Task.Run(hearthbeat);
            
        }

        private void InitializeDropdownsAndSettings()
        {
            nudOrder1Price.Value = Properties.Settings.Default.order1Price;
            nudOrder7Price.Value = Properties.Settings.Default.order7Price;
            nudOrder2Percent.Value = Properties.Settings.Default.order2Percent;
            nudOrder3Percent.Value = Properties.Settings.Default.order3Percent;
            nudOrder4Percent.Value = Properties.Settings.Default.order4Percent;
            nudOrder5Percent.Value = Properties.Settings.Default.order5Percent;
            nudOrder6Percent.Value = Properties.Settings.Default.order6Percent;
            nudOrder8Percent.Value = Properties.Settings.Default.order8Percent;
            nudOrder9Percent.Value = Properties.Settings.Default.order9Percent;
            nudOrder10Percent.Value = Properties.Settings.Default.order10Percent;
            nudOrder11Percent.Value = Properties.Settings.Default.order11Percent;
            nudOrder12Percent.Value = Properties.Settings.Default.order12Percent;
            nudOrder2Qty.Value = Properties.Settings.Default.order2Quantity;
            nudOrder3Qty.Value = Properties.Settings.Default.order3Quantity;
            nudOrder4Qty.Value = Properties.Settings.Default.order4Quantity;
            nudOrder5Qty.Value = Properties.Settings.Default.order5Quantity;
            nudOrder6Qty.Value = Properties.Settings.Default.order6Quantity;
            nudOrder8Qty.Value = Properties.Settings.Default.order8Quantity;
            nudOrder9Qty.Value = Properties.Settings.Default.order9Quantity;
            nudOrder10Qty.Value = Properties.Settings.Default.order10Quantity;
            nudOrder11Qty.Value = Properties.Settings.Default.order11Quantity;
            nudOrder12Qty.Value = Properties.Settings.Default.order12Quantity;
            
            nudSum.Value = Properties.Settings.Default.BOTstartQty;
            txtKey.Text = Properties.Settings.Default.key;
            txtSecret.Text = Properties.Settings.Default.secret;
            txtDomain.Text = Properties.Settings.Default.domain;
            txtSocket.Text = Properties.Settings.Default.socketDomain;
        }

        private void SaveDropDownAndSettings()
        {
            Properties.Settings.Default.order1Price = nudOrder1Price.Value;
            Properties.Settings.Default.order7Price = nudOrder7Price.Value;
            Properties.Settings.Default.order2Percent = nudOrder2Percent.Value;
            Properties.Settings.Default.order3Percent = nudOrder3Percent.Value;
            Properties.Settings.Default.order4Percent = nudOrder4Percent.Value;
            Properties.Settings.Default.order5Percent = nudOrder5Percent.Value;
            Properties.Settings.Default.order6Percent = nudOrder6Percent.Value;
            Properties.Settings.Default.order8Percent = nudOrder8Percent.Value;
            Properties.Settings.Default.order9Percent = nudOrder9Percent.Value;
            Properties.Settings.Default.order10Percent = nudOrder10Percent.Value;
            Properties.Settings.Default.order11Percent = nudOrder11Percent.Value;
            Properties.Settings.Default.order12Percent = nudOrder12Percent.Value;
            Properties.Settings.Default.order2Quantity = Convert.ToInt32(nudOrder2Qty.Value);
            Properties.Settings.Default.order3Quantity = Convert.ToInt32(nudOrder3Qty.Value);
            Properties.Settings.Default.order4Quantity = Convert.ToInt32(nudOrder4Qty.Value);
            Properties.Settings.Default.order5Quantity = Convert.ToInt32(nudOrder5Qty.Value);
            Properties.Settings.Default.order6Quantity = Convert.ToInt32(nudOrder6Qty.Value);
            Properties.Settings.Default.order8Quantity = Convert.ToInt32(nudOrder8Qty.Value);
            Properties.Settings.Default.order9Quantity = Convert.ToInt32(nudOrder9Qty.Value);
            Properties.Settings.Default.order10Quantity = Convert.ToInt32(nudOrder10Qty.Value) ;
            Properties.Settings.Default.order11Quantity = Convert.ToInt32(nudOrder11Qty.Value);
            Properties.Settings.Default.order12Quantity = Convert.ToInt32(nudOrder12Qty.Value);

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
            bitmex = BitmexApiConnector.Instance;
            bitmex.ApiKey = Properties.Settings.Default.key;
            bitmex.ApiSecret = Properties.Settings.Default.secret;
            bitmex.Domain = Properties.Settings.Default.domain;
            activeInstrument = ActiveInstrument.Instance;
            // We must do this in case symbols are different on test and real net
            // GetAPIValidity(); // Validate API keys by checking and displaying account balance.
            // InitializeSymbolInformation();
            InitializeSymbolInfromation();
        }

        
        private void InitializeSymbolInfromation()
        {
            activeInstrument.RequestActiveInstruments();
            listInstruments =  activeInstrument.GetInstruments().ToList();
            ddlSymbol.DataSource = listInstruments;
            ddlSymbol.DisplayMember = "Symbol";
            ddlSymbol.SelectedIndex = 0;
            activeInstrument.ChangeActiveInstrument(((Instrument)ddlSymbol.SelectedItem).Symbol);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveDropDownAndSettings();
        }

        private void DdlSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeInstrument.ChangeActiveInstrument(((Instrument)ddlSymbol.SelectedItem).Symbol);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SocketGetOrders.DataSource = orderDTO.orderList;
        }

        private void Refrest12CandlesGrid_Click(object sender, EventArgs e)
        {
            dataGridCandles.DataSource = candleRetriever.getBuildingCandles();
            List<Candle> holder = new List<Candle>();
            Candle candle12Hour= candleRetriever.Candle12Hour;
            holder.Add(candle12Hour);
            dataGrind12Hour.DataSource = holder;
        }

        private void BtnDeleteByClorID_Click(object sender, EventArgs e)
        {
            string clorid = txtDeleteByClorid.Text;
            bitmex.DeleteOrder(clorid);
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            bot.Start();
        }
    }

}


