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
    public partial class CashierLogin : Form
    {
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog=RestaurantSystem;Trusted_Connection=True;");
        SqlCommand cmd;
        public CashierLogin()
        {
            InitializeComponent();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clear()
        {
            cashierName.Clear();
            cashierPassword.Clear();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (cashierName.Text.ToString() == string.Empty || cashierPassword.Text.ToString() == string.Empty)
            {
                MessageBox.Show("Invalid Login Please Try Again !!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT password FROM Cashiers WHERE name='" + cashierName.Text.ToString() + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    if (sdr["password"].ToString() == cashierPassword.Text.ToString())
                    {
                        // Login = true;
                        MessageBox.Show("Loged in", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Please Try Again !!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login Please Try Again !!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
                con.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            this.Hide();
            start.Show();
        }
    }
}
