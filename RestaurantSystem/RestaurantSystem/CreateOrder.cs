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
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="" && textBox5.Text != "" && textBox6.Text != "")
            {
                cmd= new SqlCommand ("insert into Orders values("+textBox6.Text+",'"+textBox5.Text+"'," + textBox1.Text +")",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                OrderItems or = new OrderItems();
                or.Show();
            }
          else
            {
                MessageBox.Show("Please enter the data");
            }
        }
    }
}
