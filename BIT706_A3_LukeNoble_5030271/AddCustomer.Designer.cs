namespace BIT706_A3_LukeNoble_5030271
{
    partial class AddCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lCustomerName = new System.Windows.Forms.Label();
            this.lAddCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(112, 155);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(155, 38);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(52, 126);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(279, 23);
            this.tbCustomerName.TabIndex = 6;
            // 
            // lCustomerName
            // 
            this.lCustomerName.AutoSize = true;
            this.lCustomerName.Location = new System.Drawing.Point(52, 108);
            this.lCustomerName.Name = "lCustomerName";
            this.lCustomerName.Size = new System.Drawing.Size(97, 15);
            this.lCustomerName.TabIndex = 5;
            this.lCustomerName.Text = "Customer Name:";
            // 
            // lAddCustomer
            // 
            this.lAddCustomer.AutoSize = true;
            this.lAddCustomer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lAddCustomer.Location = new System.Drawing.Point(70, 63);
            this.lAddCustomer.Name = "lAddCustomer";
            this.lAddCustomer.Size = new System.Drawing.Size(222, 32);
            this.lAddCustomer.TabIndex = 4;
            this.lAddCustomer.Text = "Add New Customer";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 218);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lCustomerName);
            this.Controls.Add(this.lAddCustomer);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);

        }

        #endregion

        private Button btnAddCustomer;
        private TextBox tbCustomerName;
        private Label lCustomerName;
        private Label lAddCustomer;
    }
}