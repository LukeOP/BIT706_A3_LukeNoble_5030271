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
    public partial class EditCustomer : BrandingForm
    {
        protected string customerName = "";
        public EditCustomer()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            customerName = control.cust.Name;
            tbCustomerName.Text = customerName;
            cbStaff.Checked = control.cust.IsStaff;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            control.EditCustomer(control.cust, tbCustomerName.Text, cbStaff.Checked);
            if(control.ErrorMessage.Length > 0) MessageBox.Show(control.ErrorMessage, "Customer Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(control.InfoMessage.Length > 0) MessageBox.Show(control.InfoMessage, "Customer Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
