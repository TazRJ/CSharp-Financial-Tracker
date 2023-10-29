using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace FinancialTracker
{
    public partial class ViewStocks : Form
    {
        public ViewStocks()
        {
            InitializeComponent();
        }


        private void label42_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewStocks Obj = new ViewStocks();
            Obj.Show();
            this.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fetchDataButton_Click(object sender, EventArgs e)
        {
            string apiKey = "XOINFX2UWYS3PNJT"; // Replace with your Alpha Vantage API key
            string symbol = symbolComboBox.SelectedItem.ToString();
            string apiUrl = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol={symbol}&interval=5min&apikey={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //HttpResponseMessage response = await client.GetAsync(apiUrl);
                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string content = response.Content.ReadAsStringAsync().Result;
                        //string content = await response.Content.ReadAsStringAsync();
                        JObject data = JObject.Parse(content);

                        if (data["Time Series (5min)"] != null)
                        {
                            JObject timeSeries = (JObject)data["Time Series (5min)"];

                            dataGridView1.Rows.Clear();

                            foreach (var item in timeSeries)
                            {
                                var time = item.Key;
                                var price = item.Value["1. open"].ToString();
                                dataGridView1.Rows.Add(time, price);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data found in the response.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while making the request to the API.");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}

