﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=TarunLaptop\SQLEXPRESS;Initial Catalog=FinanceDbv2;Integrated Security=True");
        public static string User;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PwdTb.Text == "") 
            {
                MessageBox.Show("Enter Both Username and Password");
            } else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where UName = '" + UnameTb.Text + "' and UPass='" + PwdTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User = UnameTb.Text;
                    Dashboard Obj = new Dashboard();
                    Obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                    UnameTb.Text = "";
                    PwdTb.Text = "";
                }
                Con.Close();
            }
        }
    }
}
