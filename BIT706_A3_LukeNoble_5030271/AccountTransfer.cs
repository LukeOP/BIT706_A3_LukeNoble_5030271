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
    public partial class AccountTransfer : BrandingForm
    {
        List<Account> AllAccounts = new List<Account>();
        public AccountTransfer()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            foreach (Account account in control.cust.Accounts)
            {
                AllAccounts.Add(account);
            }
            DisplayAccounts();
        }

        public void DisplayAccounts()
        {
            lbAccountsFrom.Items.Clear();
            lbAccountsTo.Items.Clear();
            foreach (Account a in AllAccounts)
            {
                lbAccountsFrom.Items.Add(a);
                lbAccountsTo.Items.Add(a);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            control.ResetMessages();
            if (lbAccountsFrom.SelectedItems.Count == 0 || lbAccountsTo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select both a to and from account", "Accounts not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lbAccountsFrom.SelectedItem == lbAccountsTo.SelectedItem)
            {
                MessageBox.Show("You can not make transfers between the same account", "Accounts not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbTransferAmount.Text.Length == 0)
            {
                MessageBox.Show("You must submit an amount to transfer", "Transfer Amount not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                control.handleTransfer((Account)lbAccountsFrom.SelectedItem, (Account)lbAccountsTo.SelectedItem, Double.Parse(tbTransferAmount.Text));
                if(control.ErrorMessage.Length > 0)
                {
                    MessageBox.Show(control.ErrorMessage, "Transfer Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisplayAccounts();
                }
                else
                {
                    control.InfoMessage = "Transfer Successful";
                    this.Close();
                }
                
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTransferAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
