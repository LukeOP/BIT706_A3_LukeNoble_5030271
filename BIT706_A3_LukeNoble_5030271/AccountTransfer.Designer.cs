namespace BIT706_A3_LukeNoble_5030271
{
    partial class AccountTransfer
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
            this.lbAccountsFrom = new System.Windows.Forms.ListBox();
            this.lbAccountsTo = new System.Windows.Forms.ListBox();
            this.lTransferFrom = new System.Windows.Forms.Label();
            this.lTransferTo = new System.Windows.Forms.Label();
            this.tbTransferAmount = new System.Windows.Forms.TextBox();
            this.lTransferLabel = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAccountsFrom
            // 
            this.lbAccountsFrom.FormattingEnabled = true;
            this.lbAccountsFrom.ItemHeight = 15;
            this.lbAccountsFrom.Location = new System.Drawing.Point(12, 101);
            this.lbAccountsFrom.Name = "lbAccountsFrom";
            this.lbAccountsFrom.Size = new System.Drawing.Size(229, 94);
            this.lbAccountsFrom.TabIndex = 4;
            // 
            // lbAccountsTo
            // 
            this.lbAccountsTo.FormattingEnabled = true;
            this.lbAccountsTo.ItemHeight = 15;
            this.lbAccountsTo.Location = new System.Drawing.Point(433, 101);
            this.lbAccountsTo.Name = "lbAccountsTo";
            this.lbAccountsTo.Size = new System.Drawing.Size(229, 94);
            this.lbAccountsTo.TabIndex = 5;
            // 
            // lTransferFrom
            // 
            this.lTransferFrom.AutoSize = true;
            this.lTransferFrom.Location = new System.Drawing.Point(75, 76);
            this.lTransferFrom.Name = "lTransferFrom";
            this.lTransferFrom.Size = new System.Drawing.Size(82, 15);
            this.lTransferFrom.TabIndex = 6;
            this.lTransferFrom.Text = "Transfer From:";
            // 
            // lTransferTo
            // 
            this.lTransferTo.AutoSize = true;
            this.lTransferTo.Location = new System.Drawing.Point(513, 76);
            this.lTransferTo.Name = "lTransferTo";
            this.lTransferTo.Size = new System.Drawing.Size(66, 15);
            this.lTransferTo.TabIndex = 7;
            this.lTransferTo.Text = "Transfer To:";
            // 
            // tbTransferAmount
            // 
            this.tbTransferAmount.Location = new System.Drawing.Point(247, 101);
            this.tbTransferAmount.Name = "tbTransferAmount";
            this.tbTransferAmount.Size = new System.Drawing.Size(180, 23);
            this.tbTransferAmount.TabIndex = 8;
            // 
            // lTransferLabel
            // 
            this.lTransferLabel.AutoSize = true;
            this.lTransferLabel.Location = new System.Drawing.Point(275, 76);
            this.lTransferLabel.Name = "lTransferLabel";
            this.lTransferLabel.Size = new System.Drawing.Size(110, 15);
            this.lTransferLabel.TabIndex = 9;
            this.lTransferLabel.Text = "Amount To Transfer";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(247, 130);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(180, 23);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "Confirm Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(564, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AccountTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 214);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lTransferLabel);
            this.Controls.Add(this.tbTransferAmount);
            this.Controls.Add(this.lTransferTo);
            this.Controls.Add(this.lTransferFrom);
            this.Controls.Add(this.lbAccountsTo);
            this.Controls.Add(this.lbAccountsFrom);
            this.Name = "AccountTransfer";
            this.Text = "AccountTransfer";
            this.Controls.SetChildIndex(this.lbAccountsFrom, 0);
            this.Controls.SetChildIndex(this.lbAccountsTo, 0);
            this.Controls.SetChildIndex(this.lTransferFrom, 0);
            this.Controls.SetChildIndex(this.lTransferTo, 0);
            this.Controls.SetChildIndex(this.tbTransferAmount, 0);
            this.Controls.SetChildIndex(this.lTransferLabel, 0);
            this.Controls.SetChildIndex(this.btnTransfer, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbAccountsFrom;
        private ListBox lbAccountsTo;
        private Label lTransferFrom;
        private Label lTransferTo;
        private TextBox tbTransferAmount;
        private Label lTransferLabel;
        private Button btnTransfer;
        private Button btnCancel;
    }
}