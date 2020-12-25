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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            ManagerLogin manager = new ManagerLogin();
            this.Hide();
            manager.Show();
        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
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
