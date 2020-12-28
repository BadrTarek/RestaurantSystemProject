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

namespace RestaurantSystem
{
    public partial class CreateOrder : Form
    {
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog =RestaurantSystem;Trusted_Connection=True");
        SqlCommand cmd;
        private bool isLogedin = false;
        private int cashierID = 0;
        public CreateOrder(bool isLogin, int cashierID)
        {
            InitializeComponent();
            isLogedin = isLogin;
            this.cashierID = cashierID;
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            if (!isLogedin)
            {
                this.Hide();
                CashierLogin cashier = new CashierLogin();
                cashier.Show();
            }
        }
        
        
        private void createOrderButton_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string date = String.Format("{0:d/M/yyyy}", dt.Date);
            cmd = new SqlCommand("INSERT INTO Orders(totalPrice,orderDate,cashier#) VALUES(0,'1/12/2020'," + cashierID + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            con.Open();
            cmd = new SqlCommand("SELECT order# FROM Orders WHERE order#= (SELECT MAX(order#) FROM Orders)", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                int orderID = Convert.ToInt32(sdr["order#"]);
                OrderItems or = new OrderItems(isLogedin, cashierID, orderID);
                or.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Please Try Again !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            isLogedin = false;
            CashierLogin cashier = new CashierLogin();
            this.Hide();
            cashier.Show();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
