using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTracker
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            getTotalExp();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TarunLaptop\SQLEXPRESS;Initial Catalog=FinanceDbv2;Integrated Security=True");
        private void Clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            ExpDescTb.Text = "";
            ExpCatCb.SelectedIndex = 0;
        }
        private void AddExpBtn_Click(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || ExpCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTbl(ExpName,ExpAmount,ExpCat,ExpDate,ExpDesc,ExpUser)values(@EN,@EA,@EC,@EDA,@EDE,@EU)", Con);
                    cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", ExpCatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@EDA", ExpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EDE", ExpDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.User);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Added!");
                    Con.Close();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void getTotalExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmount) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TotalExpLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }
    }
}
