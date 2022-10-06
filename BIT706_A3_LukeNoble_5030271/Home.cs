using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            if (File.Exists("../../../BankData.bin")) control.ReadBinaryData();
        }

        private void btnManageCustomers_Click_1(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            this.Hide();
            manageCustomers.ShowDialog();

            this.Show();

        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            AccountManagement manageAccounts = new AccountManagement();
            this.Hide();
            manageAccounts.ShowDialog();

            this.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            control.WriteBinaryData();
            this.Close();
        }
    }
}
