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
    public partial class CashierAccounts : Form
    {
        private bool isLogin = false;
        public CashierAccounts( bool login )
        {
            InitializeComponent();
            isLogin = login;
        }

        private void CashierAccounts_Load(object sender, EventArgs e)
        {
            if(isLogin==false)
            {
                this.Hide();
            }
        }

    }
}
