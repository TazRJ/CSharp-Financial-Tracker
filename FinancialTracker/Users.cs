using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinancialTracker
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TarunLaptop\SQLEXPRESS;Initial Catalog=FinanceDbv2;Integrated Security=True");
        private void Clear()
        {
            UnameTb.Text = "";
            PhoneTb.Text = "";
            PwdTb.Text = "";
            AddressTb.Text = "";
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || PwdTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTbl(UName,UDob,UPhone,UPass,UAddress)values(@UN,@UD,@UP,@UPA,@UA)", Con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@UP", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@UPA", PwdTb.Text);
                    cmd.Parameters.AddWithValue("@UA", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added!");
                    Con.Close();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
