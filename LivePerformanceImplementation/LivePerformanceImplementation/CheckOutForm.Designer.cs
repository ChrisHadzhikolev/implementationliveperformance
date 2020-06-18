namespace LivePerformanceImplementation
{
    partial class CheckOutForm
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
            this.rfidLbl = new System.Windows.Forms.Label();
            this.rfidTb = new System.Windows.Forms.TextBox();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rfidLbl
            // 
            this.rfidLbl.AutoSize = true;
            this.rfidLbl.Location = new System.Drawing.Point(43, 61);
            this.rfidLbl.Name = "rfidLbl";
            this.rfidLbl.Size = new System.Drawing.Size(48, 20);
            this.rfidLbl.TabIndex = 0;
            this.rfidLbl.Text = "RFID";
            // 
            // rfidTb
            // 
            this.rfidTb.Location = new System.Drawing.Point(116, 61);
            this.rfidTb.Name = "rfidTb";
            this.rfidTb.Size = new System.Drawing.Size(161, 26);
            this.rfidTb.TabIndex = 1;
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(283, 61);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(107, 26);
            this.checkOutBtn.TabIndex = 2;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 142);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.rfidTb);
            this.Controls.Add(this.rfidLbl);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rfidLbl;
        private System.Windows.Forms.TextBox rfidTb;
        private System.Windows.Forms.Button checkOutBtn;
    }
}