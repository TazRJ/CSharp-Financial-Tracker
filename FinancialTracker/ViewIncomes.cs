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
    public partial class ViewIncomes : Form
    {
        public ViewIncomes()
        {
            InitializeComponent();
            DisplayIncomes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void DisplayIncomes()
        {
            Con.Open();
            string Query = "select * from IncomeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            IncomeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TarunLaptop\SQLEXPRESS;Initial Catalog=FinanceDbv2;Integrated Security=True");

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
