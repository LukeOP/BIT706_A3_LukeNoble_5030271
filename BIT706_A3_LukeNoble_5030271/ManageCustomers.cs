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
    public partial class ManageCustomers : BrandingForm
    {
        public ManageCustomers()
        {
            InitializeComponent();

            // For development - Create dummy customers
            PopulateCustomerList();
        }

        // Refresh listbox by clearing items and adding them again from AllCust list
        public void DisplayCustomers()
        {
            lbCustomers.Items.Clear();
            foreach (Customer c in control.AllCust)
            {
                lbCustomers.Items.Add(c);
            }
        }

        /*
         * For Development Use - Populate dummy customers
         */
        public void PopulateCustomerList()
        {
            if (control.AllCust.Count == 0)
            {
                control.CreateCustomer("James Wilson", false);
                control.CreateCustomer("Sam Clive", false);
                control.CreateCustomer("Suzie Morrison", false);
                control.CreateCustomer("Julia Gaines", true);
            }
            DisplayCustomers();
        }
        /*
         * End of Development Methods
         */

        // Open add customer dialog form

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer();
            this.Hide();
            addCust.ShowDialog();

            this.Show();
            DisplayCustomers();

        }

        // Check customer selected and open edit customer dialog form
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (validateCustomerSelected())
            {
                EditCustomer editCust = new EditCustomer();
                this.Hide();
                editCust.ShowDialog();

                this.Show();
                DisplayCustomers();
            }
        }

        // Check customer selected and confirm deletion
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (validateCustomerSelected())
            {
                string message = "Are you sure your wish to delete " + control.cust.Name + " from the customer list?";
                string title = "Delete Customer?";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    control.DeleteCustomer(control.cust);
                    DisplayCustomers();
                }
            }
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            if(validateCustomerSelected())
            {
                AccountManagement accountManagement = new AccountManagement();
                this.Hide();
                accountManagement.ShowDialog();

                this.Show();
                DisplayCustomers();
            }
        }
        // Check customer is selected from listbox, store customer object in controller
        private bool validateCustomerSelected()
        {
            try
            {
                Customer cust = (Customer)lbCustomers.Items[lbCustomers.SelectedIndex];
                control.cust = cust;
                return true;
            }
            catch
            {
                MessageBox.Show("You must select a customer first", "Invalid Customer Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Close Manage customer window
        private void btnMenu_Click(object sender, EventArgs e)
        {
            control.ResetMessages();
            this.Close();
        }
    }
}
