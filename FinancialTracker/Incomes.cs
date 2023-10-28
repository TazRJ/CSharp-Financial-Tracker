using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTracker
{
    public partial class Incomes : Form
    {
        public Incomes()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Incomes_Load(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=TarunLaptop\SQLEXPRESS;Initial Catalog=FinanceDbv2;Integrated Security=True");
        private void Clear()
        {
            IncNameTb.Text = "";
            IncAmountTb.Text = "";
            IncDescTb.Text = "";
            CatCb.SelectedIndex = 0;
        }
        private void SubIncBtn_Click(object sender, EventArgs e)
        {
            if (IncNameTb.Text == "" || IncAmountTb.Text == "" || IncDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into IncomeTbl(IncName,IncAmount,IncCat,IncDate,IncDesc,IncUser)values(@IN,@IA,@IC,@IDA,@IDE,@IU)", Con);
                    cmd.Parameters.AddWithValue("@IN", IncNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", IncAmountTb.Text);
                    cmd.Parameters.AddWithValue("@IC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IDA", IncomeDate.Value.Date);
                    cmd.Parameters.AddWithValue("@IDE", IncDescTb.Text);
                    cmd.Parameters.AddWithValue("@IU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Added!");
                    Con.Close();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }
    }
}
