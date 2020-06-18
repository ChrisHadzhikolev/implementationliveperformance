namespace LivePerformanceImplementation
{
    partial class Form1
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
            this.rfidTb = new System.Windows.Forms.TextBox();
            this.rfidLbl = new System.Windows.Forms.Label();
            this.checkInBtn = new System.Windows.Forms.Button();
            this.ticketLbl = new System.Windows.Forms.Label();
            this.ticketNumTb = new System.Windows.Forms.TextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rfidTb
            // 
            this.rfidTb.Location = new System.Drawing.Point(458, 30);
            this.rfidTb.Name = "rfidTb";
            this.rfidTb.Size = new System.Drawing.Size(237, 26);
            this.rfidTb.TabIndex = 0;
            // 
            // rfidLbl
            // 
            this.rfidLbl.AutoSize = true;
            this.rfidLbl.Location = new System.Drawing.Point(393, 30);
            this.rfidLbl.Name = "rfidLbl";
            this.rfidLbl.Size = new System.Drawing.Size(48, 20);
            this.rfidLbl.TabIndex = 1;
            this.rfidLbl.Text = "RFID";
            // 
            // checkInBtn
            // 
            this.checkInBtn.Enabled = false;
            this.checkInBtn.Location = new System.Drawing.Point(415, 88);
            this.checkInBtn.Name = "checkInBtn";
            this.checkInBtn.Size = new System.Drawing.Size(280, 40);
            this.checkInBtn.TabIndex = 2;
            this.checkInBtn.Text = "Check In";
            this.checkInBtn.UseVisualStyleBackColor = true;
            this.checkInBtn.Click += new System.EventHandler(this.checkInBtn_Click);
            // 
            // ticketLbl
            // 
            this.ticketLbl.AutoSize = true;
            this.ticketLbl.Location = new System.Drawing.Point(31, 30);
            this.ticketLbl.Name = "ticketLbl";
            this.ticketLbl.Size = new System.Drawing.Size(111, 20);
            this.ticketLbl.TabIndex = 4;
            this.ticketLbl.Text = "Ticket Number";
            // 
            // ticketNumTb
            // 
            this.ticketNumTb.Location = new System.Drawing.Point(148, 27);
            this.ticketNumTb.Name = "ticketNumTb";
            this.ticketNumTb.Size = new System.Drawing.Size(219, 26);
            this.ticketNumTb.TabIndex = 3;
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(87, 88);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(280, 40);
            this.verifyBtn.TabIndex = 5;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 152);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.ticketLbl);
            this.Controls.Add(this.ticketNumTb);
            this.Controls.Add(this.checkInBtn);
            this.Controls.Add(this.rfidLbl);
            this.Controls.Add(this.rfidTb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rfidTb;
        private System.Windows.Forms.Label rfidLbl;
        private System.Windows.Forms.Button checkInBtn;
        private System.Windows.Forms.Label ticketLbl;
        private System.Windows.Forms.TextBox ticketNumTb;
        private System.Windows.Forms.Button verifyBtn;
    }
}

