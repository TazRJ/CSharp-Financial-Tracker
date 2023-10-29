using System.Data;
using System.Data.SqlClient;

namespace FinancialTracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            getTotalInc();
            getTotalExp();
            getNoExp();
            getNoInc();
            GetIncLDate();
            GetExpLDate();
            getMaxInc();
            getMinInc();
            getMaxExp();
            getMinExp();
            getBalance();
            getMaxExpCat();
            getMaxIncCat();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Inclbl_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewIncomes Obj = new ViewIncomes();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Server=tcp:sqldatabasefinance.database.windows.net,1433;Initial Catalog=FinanceDB;Persist Security Info=False;User ID=test;Password=!abcd123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        int Inc, Exp;
        private void getTotalInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmount) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotalIncLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
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
                Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotalExpLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void getBalance()
        {
            double Bal = Inc - Exp;
            BalanceLbl.Text = "$ " + Bal;
        }

        private void getNoExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NoExpLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void getNoInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NoIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void GetIncLDate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateIncLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void GetExpLDate()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ExpLDateLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void getMaxInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncAmount) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxIncLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void getMinInc()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(IncAmount) from IncomeTbl where IncUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinIncLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void getMaxExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmount) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxExpLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }
        private void getMinExp()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmount) from ExpenseTbl where ExpUser='" + Login.User + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinExpLbl.Text = "$ " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }
        private void getMaxExpCat()
        {
            try
            {
                Con.Open();
                String InnerQuery = "select Max(ExpAmount) from ExpenseTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select ExpCat from ExpenseTbl where ExpAmount = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestExpCatLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void getMaxIncCat()
        {
            try
            {
                Con.Open();
                String InnerQuery = "select Max(IncAmount) from IncomeTbl";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select IncCat from IncomeTbl where IncAmount = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestIncCatLbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception)
            {
                Con.Close();
            }

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}