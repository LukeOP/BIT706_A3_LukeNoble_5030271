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
    public partial class AccountManagement : BrandingForm
    {
        // Create Lists to be used in displaying accounts and transactions. AllTransactions list is storing values but is not yet being used.
        List<Account> AllAccounts = new List<Account>();
        List<string> AllTransactions = new List<string>();
        public AccountManagement()
        {
            InitializeComponent();
            ResetMessages();
            setCustomerData();
        }
        private void setCustomerData()
        {
            lCustomerName.Text = control.cust.Name;
            if (control.cust.IsStaff) lStaffMember.Text = "Staff Member: True";
            else lStaffMember.Text = "Staff Member: False";
            AllAccounts.Clear();
            foreach (Account account in control.cust.Accounts)
            {
                AllAccounts.Add(account);
            }
            DisplayAccounts();
        }

        // Refreshes accounts listbox by clearing the list and repopulating from Account List
        private void DisplayAccounts()
        {
            lstAccounts.Items.Clear();
            foreach (Account a in AllAccounts)
            {
                lstAccounts.Items.Add(a);
            }
        }

        // Adds a recent transaction to the transaction listbox
        private void AddTransactions(String transaction)
        {
            AllTransactions.Add(transaction);
            lstTransactions.Items.Add(transaction);
        }

        // On deposit Button click, validate input then deposit value and print transaction to listbox, refresh account list
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                control.deposit(account, Double.Parse(tbAmount.Text));

                updateTransactions();
            }
        }

        // On withdraw Button click, validate input then attempt withdraw from account.withdraw method. Print transaction to list and refresh account list
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                control.withdraw(account, Double.Parse(tbAmount.Text));
                if(control.ErrorMessage != "")
                {
                    MessageBox.Show(control.ErrorMessage, "Unable to Withdraw Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                updateTransactions();
            }
        }

        // On calculate interest click, check account is selected and then add interest based on account values. refresh lists and print transaction.
        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (ValidateAccountSelected())
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                control.addInterest(account);
                if (control.ErrorMessage != "")
                {
                    MessageBox.Show(control.ErrorMessage, "Unable to Withdraw Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                updateTransactions();
            }
        }

        // Checks account is selected and input value is greater than 0
        private bool ValidateInput()
        {
            ResetMessages();
            if (!ValidateAccountSelected()) return false;
            if (tbAmount.Text == "" || Double.Parse(tbAmount.Text) <= 0)
            {
                MessageBox.Show("Entered amount must be greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidateAccountSelected()
        {
            if (lstAccounts.SelectedItem != null) return true;
            MessageBox.Show("No account Selected", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        private void updateTransactions()
        {
            AddTransactions(control.getLastTransaction());
            DisplayAccounts();
            ResetMessages();
            tbAmount.Text = "";
        }
        private void ResetMessages()
        {
            control.ResetMessages();
            lErrorMessage.Text = control.ErrorMessage;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            this.Hide();
            addAccount.ShowDialog();

            this.Show();
            setCustomerData();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            AccountTransfer transfer = new AccountTransfer();
            this.Hide();
            transfer.ShowDialog();

            this.Show();
            DisplayAccounts();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
