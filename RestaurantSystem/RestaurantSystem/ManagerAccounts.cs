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
    public partial class ManagerAccounts : Form
    {
        private bool isLogin = false;
        private string managerNameLogedin = null;
        SqlConnection con = new SqlConnection("data source=.;Initial Catalog=RestaurantSystem;Trusted_Connection=True;");
        SqlCommand cmd;
        private int managerID = 0;
        private bool isEditing = false;
        public ManagerAccounts( bool login , string name)
        {
            InitializeComponent();
            isLogin = login;
            managerNameLogedin =  name; 
        }
        private void clear()
        {
            name.Clear();
            password.Clear();
            searchName.Clear();
        }
        private void displayData(string searchName = null)
        {
            if (searchName == null)
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT name FROM Managers", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                managerNames.DataSource = dt;
            }
            else
            {
                con.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand("SELECT name FROM Managers WHERE name LIKE '" + searchName + "' ", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                managerNames.DataSource = dt;
            }
        }
        private void reset()
        {
            displayData();
            managerNames.ClearSelection();
            clear();
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            addButton.Enabled = true;
            managerID = 0;
            isEditing = false;
        }
        private bool validation()
        {
            if (name.Text.ToString() == string.Empty || password.Text.ToString() == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ManagerAccounts_Load(object sender, EventArgs e)
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
                cmd = new SqlCommand("INSERT INTO Managers(name,password) VALUES('" + name.Text.ToString() + "','" + password.Text.ToString() + "') ", con);
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

        private void managerNames_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (managerNames.CurrentRow != null)
            {
                con.Open();
                cmd = new SqlCommand("SELECT manager# , password FROM Managers WHERE name = '" + managerNames.CurrentRow.Cells[0].Value.ToString() + "' ", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    name.Text = managerNames.CurrentRow.Cells[0].Value.ToString();
                    password.Text = sdr["password"].ToString();
                    updateButton.Enabled = true;
                    deleteButton.Enabled = true;
                    addButton.Enabled = false;
                    isEditing = true;
                    managerID = Convert.ToInt32(sdr["manager#"].ToString());
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
            if (isEditing && managerID > 0)
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Managers SET name = '" + name.Text.ToString() + "' , password='" + password.Text.ToString() + "' WHERE manager# =" + managerID + " ", con);
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
            if (isEditing && managerID > 0)
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM Managers WHERE manager# =" + managerID + " ", con);
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
