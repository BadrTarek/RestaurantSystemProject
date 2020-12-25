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
    public partial class Categories : Form
    {
        private bool isLogin = false;
        private string managerNameLogedin = null;
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog=RestaurantSystem;Trusted_Connection=True;");
        SqlCommand cmd;
        private int categoryID = 0;
        private bool isEditing = false;

        public Categories(bool login , string managerName)
        {
            InitializeComponent();
            isLogin = true;
            this.managerNameLogedin = managerName;
        }
        private void clear()
        {
            name.Clear();
            searchName.Clear();
        }
        private void displayData(string searchName = null)
        {
            if (searchName == null)
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT name FROM Categories", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                categoriesList.DataSource = dt;
            }
            else
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT name FROM Categories WHERE name LIKE '" + searchName + "' ", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                categoriesList.DataSource = dt;
            }
        }
        private void reset()
        {
            displayData();
            categoriesList.ClearSelection();
            clear();
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            addButton.Enabled = true;
            categoryID = 0;
            isEditing = false;
        }
        private bool validation()
        {
            if (name.Text.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            if(!isLogin)
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
                cmd = new SqlCommand("INSERT INTO Categories(name) VALUES('" + name.Text.ToString() + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Adding Success", "Add Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Data Must Be Valid", "Add Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void categoriesList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoriesList.CurrentRow != null)
            {
                con.Open();
                cmd = new SqlCommand("SELECT category# FROM Categories WHERE name = '" + categoriesList.CurrentRow.Cells[0].Value.ToString() + "' ", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    name.Text = categoriesList.CurrentRow.Cells[0].Value.ToString();
                    updateButton.Enabled = true;
                    deleteButton.Enabled = true;
                    addButton.Enabled = false;
                    isEditing = true;
                    categoryID = Convert.ToInt32(sdr["category#"].ToString());
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
            if (isEditing && categoryID > 0)
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Categories SET name = '" + name.Text.ToString() + "' WHERE category#="+categoryID+"", con);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isEditing && categoryID > 0)
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Categories WHERE category# =" + categoryID + "", con);
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
            ManagerDashboard manager = new ManagerDashboard(isLogin, managerNameLogedin);
            manager.Show();
        }
    }
}
