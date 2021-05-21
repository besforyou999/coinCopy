﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace CoinCopy
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            try
            {

                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;

                var reply = client.DownloadString("https://api.upbit.com/v1/market/all");

                DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(reply, (typeof(DataTable)));

                //"KRW-BTC" +"&count=1"
                //dataTable.Columns.Add("price");


                dgvCoin.DataSource = dataTable;
                //get_price(dataTable);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void get_price(DataTable dataTable)
        {
            string priceurl = "https://api.upbit.com/v1/candles/minutes/1?market=";
            WebClient tempclient = new WebClient();
            tempclient.Encoding = Encoding.UTF8;
            foreach (DataRow row in dataTable.Rows)
            {
                string tempurl = priceurl + row["market"].ToString() + "&count=1";
                var candleinfo = tempclient.DownloadString(tempurl);
                var price = JsonConvert.DeserializeObject<List<PriceEvent>>(candleinfo);
                row["price"] = price[0].opening_price.ToString();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
        public class PriceEvent
        {
            public string market { get; set; }
            public DateTime candle_date_time_utc { get; set; }
            public DateTime candle_date_time_kst { get; set; }
            public double opening_price { get; set; }
            public double high_price { get; set; }
            public double low_price { get; set; }
            public double trade_price { get; set; }
            public long timestamp { get; set; }
            public double candle_acc_trade_price { get; set; }
            public double candle_acc_trade_volume { get; set; }
            public int unit { get; set; }
        }

        private void dgvCoin_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            int n = dgvCoin.SelectedRows[0].Index;
            string code = dgvCoin.Rows[n].Cells[0].Value.ToString();
            loadCoinInfo(code);
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int n = dgvCoin.SelectedRows[0].Index;
            string code = dgvCoin.Rows[n].Cells[0].Value.ToString();
            loadCoinInfo(code);
        }

        public void loadCoinInfo(string code)
        {
            string priceurl = "https://api.upbit.com/v1/candles/minutes/1?market=";
            WebClient tempclient = new WebClient();
            tempclient.Encoding = Encoding.UTF8;

            string tempurl = priceurl + code + "&count=1";
            var candleinfo = tempclient.DownloadString(tempurl);
            var price = JsonConvert.DeserializeObject<List<PriceEvent>>(candleinfo);

            Chart chart = new Chart();
            chart.Owner = this.Owner;
            chart.lblName.Text = price[0].market.ToString();
            chart.lblPrice.Text = price[0].opening_price.ToString();

            chart.Show();
        }
    }

    
    
}