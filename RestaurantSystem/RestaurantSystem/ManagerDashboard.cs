using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class ManagerDashboard : Form
    {
        private bool isLogin = false;
        private string managerName = null;
        public ManagerDashboard(bool login , string name)
        {
            InitializeComponent();
            isLogin = login;
            this.managerName = name;
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            if(isLogin==false || managerName == string.Empty)
            {
                this.Hide();
            }
            else
            {
                welcomLabel.Text += managerName;
                welcomLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            isLogin = false;
            ManagerLogin.isLogin = false;
            this.Hide();
            ManagerLogin login = new ManagerLogin();
            login.Show();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            Products products = new Products(isLogin, managerName);
            this.Hide();
            products.Show();
        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
            CashierAccounts cashierAcounts = new CashierAccounts(isLogin , managerName);
            this.Hide();
            cashierAcounts.Show();
        }

        private void managersButton_Click(object sender, EventArgs e)
        {
            ManagerAccounts manager = new ManagerAccounts(isLogin, managerName);
            this.Hide();
            manager.Show();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            Categories category = new Categories(isLogin, managerName);
            this.Hide();
            category.Show();
        }
    }
}
