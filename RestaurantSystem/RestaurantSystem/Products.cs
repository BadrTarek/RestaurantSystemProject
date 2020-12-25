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
    public partial class Products : Form
    {
        private bool isLogin = false;
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog=RestaurantSystem;Trusted_Connection=True;");
        SqlCommand cmd;
        private int productID = 0;
        private bool isEditing = false;
        private string managerName = null;

        public Products(bool login, string managerName)
        {
            InitializeComponent();
            isLogin = login;
            this.managerName = managerName;
        }

        private void clear()
        {
            name.Clear();
            price.Clear();
            searchName.Clear();
        }

        private void displayData(string searchName = null)
        {
            if (searchName == null)
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT name , price FROM Products", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                productsList.DataSource = dt;
            }
            else
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT name , price FROM Products WHERE name LIKE '" + searchName + "' ", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                productsList.DataSource = dt;
            }
        }

        private void displayCategories()
        {
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT name  FROM Categories", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            categoriesList.DataSource = dt;
        }

        private void reset()
        {
            displayData();
            displayCategories();
            productsList.ClearSelection();
            categoriesList.ClearSelection();
            clear();
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            addButton.Enabled = true;
            productID = 0;
            isEditing = false;
        }
        private bool validation()
        {
            if (name.Text.ToString() == string.Empty || price.Text.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            if (isLogin == false)
            {
                this.Hide();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if(productsList.CurrentRow != null)
                {
                    //productsList.CurrentRow.Cells[0].Value.ToString();
                    cmd = new SqlCommand("INSERT INTO Products(name,price,category#) VALUES('" + name.Text.ToString() + "'," + float.Parse( price.Text) + ",(SELECT category# FROM Categories WHERE name = '"+ categoriesList.CurrentRow.Cells[0].Value.ToString() + "' ) ) ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Adding Success", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                
            }
            else
            {
                MessageBox.Show("Data Must Be Valid", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void productsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsList.CurrentRow != null)
            {
                con.Open();
                cmd = new SqlCommand("SELECT product# , category# FROM Products WHERE name = '" + productsList.CurrentRow.Cells[0].Value.ToString() + "' ", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    int categoryID = Convert.ToInt32(sdr["category#"]);
                    productID = Convert.ToInt32(sdr["product#"]);
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("SELECT name FROM Categories WHERE category# = " + categoryID + " ", con);
                    SqlDataReader sdr2 = cmd.ExecuteReader();
                    if (sdr2.HasRows)
                    {
                        sdr2.Read();
                        name.Text = productsList.CurrentRow.Cells[0].Value.ToString();
                        price.Text = productsList.CurrentRow.Cells[1].Value.ToString();
                        categoriesList.ClearSelection();
                        foreach (DataGridViewRow row in categoriesList.Rows)
                        {
                            if(row.Cells[0].Value.ToString() == sdr2["name"].ToString() )
                            {
                                row.Selected = true;
                            }
                        }
                        updateButton.Enabled = true;
                        deleteButton.Enabled = true;
                        addButton.Enabled = false;
                        isEditing = true;
                    }
                    else
                    {
                        MessageBox.Show("Error Please Try Again !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error Please Try Again !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isEditing && productID > 0)
            {

                con.Open();
                cmd = new SqlCommand("SELECT category# FROM Categories WHERE name='"+ categoriesList.CurrentRow.Cells[0].Value.ToString() + "'",con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.HasRows)
                {
                    sdr.Read();
                    int categoryID = Convert.ToInt32(sdr["category#"]);
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("UPDATE Products SET name = '" + name.Text.ToString() + "' , price=" + float.Parse(price.Text) + " , category#= "+categoryID+" WHERE product# =" + productID + " ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    reset();
                    MessageBox.Show("Updating Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isEditing && productID > 0)
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Products WHERE product# =" + productID + " ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                reset();
                MessageBox.Show("Deleting Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchName.Text == string.Empty)
            {
                MessageBox.Show("Please Search By Valid Name ", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                displayData(searchName.Text.ToString());
                addButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerDashboard manager = new ManagerDashboard(isLogin, managerName);
            manager.Show();
        }
    }
}
