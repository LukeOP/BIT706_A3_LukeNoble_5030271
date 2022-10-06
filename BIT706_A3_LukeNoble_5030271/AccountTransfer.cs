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
            if (lbAccountsFrom.SelectedItem == null || lbAccountsTo.SelectedItem == null)
            {

            }
            else
            {
                control.handleTransfer((Account)lbAccountsFrom.SelectedItem, (Account)lbAccountsTo.SelectedItem, Double.Parse(tbTransferAmount.Text));
                this.Close();
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
