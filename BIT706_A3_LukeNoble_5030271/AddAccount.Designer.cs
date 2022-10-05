namespace BIT706_A3_LukeNoble_5030271
{
    partial class AddAccount
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lAccountType = new System.Windows.Forms.Label();
            this.lAddAccount = new System.Windows.Forms.Label();
            this.comboAccountTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(169, 161);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(155, 38);
            this.btnAddAccount.TabIndex = 12;
            this.btnAddAccount.Text = "AddAccount";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lAccountType
            // 
            this.lAccountType.AutoSize = true;
            this.lAccountType.Location = new System.Drawing.Point(45, 114);
            this.lAccountType.Name = "lAccountType";
            this.lAccountType.Size = new System.Drawing.Size(82, 15);
            this.lAccountType.TabIndex = 10;
            this.lAccountType.Text = "Account Type:";
            // 
            // lAddAccount
            // 
            this.lAddAccount.AutoSize = true;
            this.lAddAccount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddAccount.Location = new System.Drawing.Point(79, 68);
            this.lAddAccount.Name = "lAddAccount";
            this.lAddAccount.Size = new System.Drawing.Size(206, 32);
            this.lAddAccount.TabIndex = 9;
            this.lAddAccount.Text = "Add New Account";
            // 
            // comboAccountTypes
            // 
            this.comboAccountTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountTypes.FormattingEnabled = true;
            this.comboAccountTypes.Items.AddRange(new object[] {
            "Everyday Account",
            "Investment Account",
            "Omni Account"});
            this.comboAccountTypes.Location = new System.Drawing.Point(45, 132);
            this.comboAccountTypes.Name = "comboAccountTypes";
            this.comboAccountTypes.Size = new System.Drawing.Size(279, 23);
            this.comboAccountTypes.TabIndex = 13;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 218);
            this.Controls.Add(this.comboAccountTypes);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.lAccountType);
            this.Controls.Add(this.lAddAccount);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAccount";
            this.Controls.SetChildIndex(this.lAddAccount, 0);
            this.Controls.SetChildIndex(this.lAccountType, 0);
            this.Controls.SetChildIndex(this.btnAddAccount, 0);
            this.Controls.SetChildIndex(this.comboAccountTypes, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddAccount;
        private Label lAccountType;
        private Label lAddAccount;
        private ComboBox comboAccountTypes;
    }
}