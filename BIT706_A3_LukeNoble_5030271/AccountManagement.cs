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
            Form1_Shown();
        }
        private void Form1_Shown()
        {
            if (AllAccounts.Count == 0)
            {
                Everyday AccountEveryday = new Everyday(12.50);
                Investment InvestmentAccount = new Investment(1000, 10, 4);
                Omni OmniAccount = new Omni(2500, 15, 3.5, 100);
                AllAccounts.Add(AccountEveryday);
                AllAccounts.Add(InvestmentAccount);
                AllAccounts.Add(OmniAccount);
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
            lstTransactions.Items.Add(transaction);
        }

        // On Get Details Button click, gets info details from account class and displays to user with Message Box. Error if no account selected
        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedItem == null)
            {
                MessageBox.Show("No account Selected", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                MessageBox.Show(account.Info(), "Account Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // On deposit Button click, validate input then deposit value and print transaction to listbox, refresh account list
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                account.Deposit(Double.Parse(tbAmount.Text));
                AddTransactions(account.GetLastTransaction());
                AllTransactions.Add(account.GetLastTransaction().ToString());
                DisplayAccounts();
                tbAmount.Text = "";
            }
        }

        // On withdraw Button click, validate input then attempt withdraw from account.withdraw method. Print transaction to list and refresh account list
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                try
                {
                    account.Withdraw(Double.Parse(tbAmount.Text));
                }
                catch (AccountWithdrawlFailedException ex)
                {
                    MessageBox.Show(ex.Message, "Cannot Withdraw Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AddTransactions(account.GetLastTransaction());
                AllTransactions.Add(account.GetLastTransaction().ToString());
                DisplayAccounts();
                tbAmount.Text = "";
            }
        }

        // On calculate interest click, check account is selected and then add interest based on account values. refresh lists and print transaction.
        private void btnCalculateInterest_Click(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedItem == null)
            {
                MessageBox.Show("No account Selected", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Account account = (Account)lstAccounts.Items[lstAccounts.SelectedIndex];
                try
                {
                    account.AddInterest();
                }
                catch (AccountAddInterestFailedException ex)
                {
                    MessageBox.Show(ex.Message, "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                AddTransactions(account.GetLastTransaction());
                AllTransactions.Add(account.GetLastTransaction().ToString());
                DisplayAccounts();
            }
        }

        // Checks account is selected and input value is greater than 0
        private bool ValidateInput()
        {
            try
            {
                if (lstAccounts.SelectedItem == null)
                {
                    MessageBox.Show("No account Selected", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (tbAmount.Text == "" || Double.Parse(tbAmount.Text) <= 0)
                {
                    MessageBox.Show("Entered amount must be greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else return true;
            }
            catch
            {
                MessageBox.Show("Invalid Input... ", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
    }
}
