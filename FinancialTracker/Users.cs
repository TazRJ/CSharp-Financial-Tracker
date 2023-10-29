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
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Server=tcp:sqldatabasefinance.database.windows.net,1433;Initial Catalog=FinanceDB;Persist Security Info=False;User ID=test;Password=!abcd123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private void Clear()
        {
            UnameTb.Text = "";
            PhoneTb.Text = "";
            PwdTb.Text = "";
            AddressTb.Text = "";
        }

        private bool IsNumeric(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        private bool IsUsernameAvailable(string username)
        {
            // Perform a check in the database to see if the username exists
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE UName = @Username", Con);
            cmd.Parameters.AddWithValue("@Username", username);
            int count = (int)cmd.ExecuteScalar();
            Con.Close();
            // If count is 0, the username is available; otherwise, it exists.
            return count == 0; 
        }

        //registers users
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PhoneTb.Text == "" || PwdTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            if (IsNumeric(PhoneTb.Text))
            {
                if (IsUsernameAvailable(UnameTb.Text))
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
                else
                {
                    MessageBox.Show("Username already exists!");
                }
            }
            else
            {
                MessageBox.Show("Phone number must be a valid integer.");
            }

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }
        //close btn
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
