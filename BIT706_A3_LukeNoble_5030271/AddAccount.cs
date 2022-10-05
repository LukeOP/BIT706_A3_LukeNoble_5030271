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
    public partial class AddAccount : BrandingForm
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (comboAccountTypes.Text != "")
            {
                try
                {
                    control.addAccount(comboAccountTypes.Text);
                    MessageBox.Show(comboAccountTypes.Text + "Created!", "New Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (AddAccountFailedException ex)
                {
                    MessageBox.Show(ex.Message, "New Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must select an account from the dropdown options.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
