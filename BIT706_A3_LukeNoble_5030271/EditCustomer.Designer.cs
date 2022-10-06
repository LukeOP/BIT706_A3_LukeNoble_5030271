namespace BIT706_A3_LukeNoble_5030271
{
    partial class EditCustomer
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
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lCustomerName = new System.Windows.Forms.Label();
            this.lEditCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(113, 166);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(155, 38);
            this.btnEditCustomer.TabIndex = 11;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(53, 137);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(279, 23);
            this.tbCustomerName.TabIndex = 10;
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.Location = new System.Drawing.Point(53, 119);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(97, 15);
            this.lCustomerName.TabIndex = 9;
            this.lCustomerName.Text = "Customer Name:";
            // 
            // lEditCustomer
            // 
            this.lEditCustomer.AutoSize = true;
            this.lEditCustomer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lEditCustomer.Location = new System.Drawing.Point(107, 72);
            this.lEditCustomer.Name = "lEditCustomer";
            this.lEditCustomer.Size = new System.Drawing.Size(164, 32);
            this.lEditCustomer.TabIndex = 8;
            this.lEditCustomer.Text = "Edit Customer";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 218);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lCustomerName);
            this.Controls.Add(this.lEditCustomer);
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomer";
            this.Controls.SetChildIndex(this.lEditCustomer, 0);
            this.Controls.SetChildIndex(this.lCustomerName, 0);
            this.Controls.SetChildIndex(this.tbCustomerName, 0);
            this.Controls.SetChildIndex(this.btnEditCustomer, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEditCustomer;
        private TextBox tbCustomerName;
        private Label lCustomerName;
        private Label lEditCustomer;
    }
}