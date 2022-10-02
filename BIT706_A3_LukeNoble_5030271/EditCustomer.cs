﻿using System;
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
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            control.EditCustomer(control.cust, tbCustomerName.Text);
            this.Close();
        }
    }
}