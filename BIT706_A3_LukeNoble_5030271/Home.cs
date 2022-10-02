using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A3_LukeNoble_5030271
{
    public partial class Home : BrandingForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnManageCustomers_Click_1(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.ShowDialog();
            this.Hide();

            this.Show();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            AccountManagement manageAccounts = new AccountManagement();
            manageAccounts.ShowDialog();
            this.Hide();

            this.Show();
        }
    }
}
