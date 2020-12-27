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
        public int totalprice;
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog =RestaurantSystem;Trusted_Connection=True");
        SqlCommand cmd;
        SqlDataAdapter adapt ,a ;
        public OrderItems()
        {
            InitializeComponent();
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        
        
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Products",con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["product#"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            con.Open();
            cmd = new SqlCommand("update Orders set totalPrice=+"+totalprice+ "where order# =(select order# from Orders where order#= ( select max(order#) from Orders)) ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Total price = "+totalprice.ToString()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {   con.Open();
            a = new SqlDataAdapter("select order# from Orders where order#= ( select max(order#) from Orders)", con);
            DataSet ds = new DataSet();
           String order = a.Fill(ds, "order#").ToString();
            con.Close();
            con.Open();
          cmd = new SqlCommand("insert into OrderItems values(" + Convert.ToInt32(order.ToString()) + "," + Convert.ToInt32(textBox3.Text.ToString()) + "," + Convert.ToInt32(textBox2.Text.ToString()) + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
           totalprice = Convert.ToInt32(textBox4.Text.ToString())* Convert.ToInt32(textBox2.Text.ToString());
           MessageBox.Show(" items  added successfully");
        }
    }
}
