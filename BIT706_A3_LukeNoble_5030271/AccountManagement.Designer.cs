namespace BIT706_A3_LukeNoble_5030271
{
    partial class AccountManagement
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.lCustomerName = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lStaffMember = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lErrorMessage = new System.Windows.Forms.Label();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.lInfoMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Gold;
            this.btnDeposit.Location = new System.Drawing.Point(225, 155);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(178, 35);
            this.btnDeposit.TabIndex = 13;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Account List";
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 15;
            this.lstAccounts.Location = new System.Drawing.Point(12, 126);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(207, 109);
            this.lstAccounts.TabIndex = 18;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(225, 126);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.PlaceholderText = "deposit/withdraw amount";
            this.tbAmount.Size = new System.Drawing.Size(178, 23);
            this.tbAmount.TabIndex = 20;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Transaction List";
            // 
            // lstTransactions
            // 
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.HorizontalScrollbar = true;
            this.lstTransactions.ItemHeight = 15;
            this.lstTransactions.Location = new System.Drawing.Point(12, 269);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(576, 109);
            this.lstTransactions.TabIndex = 21;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Gold;
            this.btnWithdraw.Location = new System.Drawing.Point(409, 155);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(178, 35);
            this.btnWithdraw.TabIndex = 23;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.BackColor = System.Drawing.Color.Gold;
            this.btnCalculateInterest.Location = new System.Drawing.Point(409, 191);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(178, 35);
            this.btnCalculateInterest.TabIndex = 25;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = false;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCustomerName.Location = new System.Drawing.Point(12, 70);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(164, 30);
            this.lCustomerName.TabIndex = 26;
            this.lCustomerName.Text = "Customer Name";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.Gold;
            this.btnAddAccount.Location = new System.Drawing.Point(225, 227);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(178, 35);
            this.btnAddAccount.TabIndex = 27;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lStaffMember
            // 
            this.lStaffMember.AutoSize = true;
            this.lStaffMember.Location = new System.Drawing.Point(435, 78);
            this.lStaffMember.Name = "lStaffMember";
            this.lStaffMember.Size = new System.Drawing.Size(82, 15);
            this.lStaffMember.TabIndex = 28;
            this.lStaffMember.Text = "Staff Member:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Gold;
            this.btnTransfer.Location = new System.Drawing.Point(225, 191);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(178, 35);
            this.btnTransfer.TabIndex = 29;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lErrorMessage
            // 
            this.lErrorMessage.AutoSize = true;
            this.lErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lErrorMessage.Location = new System.Drawing.Point(13, 383);
            this.lErrorMessage.Name = "lErrorMessage";
            this.lErrorMessage.Size = new System.Drawing.Size(81, 15);
            this.lErrorMessage.TabIndex = 30;
            this.lErrorMessage.Text = "Error Message";
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(453, 10);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(135, 30);
            this.btnManageCustomers.TabIndex = 31;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // lInfoMessage
            // 
            this.lInfoMessage.AutoSize = true;
            this.lInfoMessage.ForeColor = System.Drawing.Color.Black;
            this.lInfoMessage.Location = new System.Drawing.Point(13, 409);
            this.lInfoMessage.Name = "lInfoMessage";
            this.lInfoMessage.Size = new System.Drawing.Size(77, 15);
            this.lInfoMessage.TabIndex = 32;
            this.lInfoMessage.Text = "Info Message";
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.lInfoMessage);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.lErrorMessage);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lStaffMember);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lCustomerName);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAccounts);
            this.Controls.Add(this.btnDeposit);
            this.Name = "AccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManagement";
            this.Controls.SetChildIndex(this.btnDeposit, 0);
            this.Controls.SetChildIndex(this.lstAccounts, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.tbAmount, 0);
            this.Controls.SetChildIndex(this.lstTransactions, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnWithdraw, 0);
            this.Controls.SetChildIndex(this.btnCalculateInterest, 0);
            this.Controls.SetChildIndex(this.lCustomerName, 0);
            this.Controls.SetChildIndex(this.btnAddAccount, 0);
            this.Controls.SetChildIndex(this.lStaffMember, 0);
            this.Controls.SetChildIndex(this.btnTransfer, 0);
            this.Controls.SetChildIndex(this.lErrorMessage, 0);
            this.Controls.SetChildIndex(this.btnManageCustomers, 0);
            this.Controls.SetChildIndex(this.lInfoMessage, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeposit;
        private Label label2;
        private ListBox lstAccounts;
        private TextBox tbAmount;
        private Label label3;
        private ListBox lstTransactions;
        private Button btnWithdraw;
        private Button btnCalculateInterest;
        private Label lCustomerName;
        private Button btnAddAccount;
        private Label lStaffMember;
        private Button btnTransfer;
        private Label lErrorMessage;
        private Button btnManageCustomers;
        private Label lInfoMessage;
    }
}