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
    public partial class AddCustomer : BrandingForm
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(tbCustomerName.Text.Length > 3)
            {
                control.CreateCustomer(tbCustomerName.Text, cbStaff.Checked);
                this.Close();
            }
            else
            {
                MessageBox.Show("The customer name chosen is too short. Are you sure you entered it correctly?", "Name too short", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
