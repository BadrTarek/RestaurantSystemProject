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
    public partial class OrderItems : Form
    {
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog =RestaurantSystem;Trusted_Connection=True");
        SqlCommand cmd;
        private bool isLogin = false;
        private int cashierID = 0;
        private int orderID = 0;
        private bool isSelectingProduct = false;
        private int productID = 0;
        private float price = 0f;
        private float totalPrice = 0f; 
        public OrderItems(bool isLogin, int cashierID , int orderID)
        {
            InitializeComponent();
            this.isLogin = isLogin;
            this.cashierID = cashierID;
            this.orderID = orderID;
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT product# , name , price  FROM Products", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            allProducts.DataSource = dt;
        }
        private void reset() {
            DisplayData();
            quantityTextBox.Enabled = false;
            addOrderItemButton.Enabled = false;
            productID = 0;
            isSelectingProduct = false;
            allProducts.ClearSelection();
            price = 0;
            quantityTextBox.Clear();
            productNameTextBox.Clear();
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                this.Hide();
                CashierLogin cashier = new CashierLogin();
                cashier.Show();
            }
            else
            {
                reset();
            }
        }
        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void allProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (allProducts.CurrentRow != null)
            {
                quantityTextBox.Enabled = true;
                addOrderItemButton.Enabled = true;
                productNameTextBox.Text = allProducts.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                productID = int.Parse(allProducts.Rows[e.RowIndex].Cells["product#"].FormattedValue.ToString());
                price = float.Parse(allProducts.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString());
                isSelectingProduct = true;
            }
        }

        private void addOrderItemButton_Click(object sender, EventArgs e)
        {

            if(quantityTextBox.Text != string.Empty && productID>0 && orderID>0 && isSelectingProduct)
            {
                int qua = int.Parse(quantityTextBox.Text.ToString());
                totalPrice +=( price*(float)qua);
                cmd = new SqlCommand("INSERT INTO OrderItems(order#,product#,quantity) VALUES(" + orderID + "," + productID + "," + qua + ") ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Adding Success", "Add Order Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Please Enter Quantity ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void finishOrder()
        {
            reset();
            orderID = 0;
            cashierID = 0;
            totalPrice = 0f;
            isLogin = false;
            isSelectingProduct = false;
            productID = 0;
            price = 0f;
            totalPrice = 0f;
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Orders SET totalPrice = " + totalPrice + " where order# = "+orderID+" ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Total price = " + totalPrice.ToString(), "Add Order Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateOrder createOrder = new CreateOrder(isLogin,cashierID);
            this.Hide();
            createOrder.Show();
            finishOrder();
        }
    }
}
