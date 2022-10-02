namespace BIT706_A3_LukeNoble_5030271
{
    partial class ManageCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.lErrorMessage = new System.Windows.Forms.Label();
            this.lInfoMessage = new System.Windows.Forms.Label();
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(335, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(102, 29);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(13, 198);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(209, 57);
            this.btnDeleteCustomer.TabIndex = 10;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(13, 135);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(209, 57);
            this.btnEditCustomer.TabIndex = 9;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(13, 72);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(209, 57);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.ItemHeight = 15;
            this.lbCustomers.Location = new System.Drawing.Point(228, 73);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(209, 184);
            this.lbCustomers.TabIndex = 7;
            // 
            // lErrorMessage
            // 
            this.lErrorMessage.AutoSize = true;
            this.lErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lErrorMessage.Location = new System.Drawing.Point(230, 282);
            this.lErrorMessage.Name = "lErrorMessage";
            this.lErrorMessage.Size = new System.Drawing.Size(0, 15);
            this.lErrorMessage.TabIndex = 13;
            // 
            // lInfoMessage
            // 
            this.lInfoMessage.AutoSize = true;
            this.lInfoMessage.Location = new System.Drawing.Point(230, 262);
            this.lInfoMessage.Name = "lInfoMessage";
            this.lInfoMessage.Size = new System.Drawing.Size(0, 15);
            this.lInfoMessage.TabIndex = 12;
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.Location = new System.Drawing.Point(12, 261);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(209, 57);
            this.btnManageAccounts.TabIndex = 14;
            this.btnManageAccounts.Text = "Manage Customer Accounts";
            this.btnManageAccounts.UseVisualStyleBackColor = true;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 326);
            this.Controls.Add(this.btnManageAccounts);
            this.Controls.Add(this.lErrorMessage);
            this.Controls.Add(this.lInfoMessage);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lbCustomers);
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Controls.SetChildIndex(this.lbCustomers, 0);
            this.Controls.SetChildIndex(this.btnAddCustomer, 0);
            this.Controls.SetChildIndex(this.btnEditCustomer, 0);
            this.Controls.SetChildIndex(this.btnDeleteCustomer, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            this.Controls.SetChildIndex(this.lInfoMessage, 0);
            this.Controls.SetChildIndex(this.lErrorMessage, 0);
            this.Controls.SetChildIndex(this.btnManageAccounts, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMenu;
        private Button btnDeleteCustomer;
        private Button btnEditCustomer;
        private Button btnAddCustomer;
        private ListBox lbCustomers;
        private Label lErrorMessage;
        private Label lInfoMessage;
        private Button btnManageAccounts;
    }
}