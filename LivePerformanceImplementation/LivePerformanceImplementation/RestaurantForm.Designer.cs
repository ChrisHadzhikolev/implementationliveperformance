namespace LivePerformanceImplementation
{
    partial class RestaurantForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.foodRBtn = new System.Windows.Forms.Button();
            this.fNum = new System.Windows.Forms.NumericUpDown();
            this.dNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rfidTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.drinkRBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food";
            // 
            // foodRBtn
            // 
            this.foodRBtn.Location = new System.Drawing.Point(655, 41);
            this.foodRBtn.Name = "foodRBtn";
            this.foodRBtn.Size = new System.Drawing.Size(110, 33);
            this.foodRBtn.TabIndex = 2;
            this.foodRBtn.Text = "Remove";
            this.foodRBtn.UseVisualStyleBackColor = true;
            this.foodRBtn.Click += new System.EventHandler(this.foodRBtn_Click);
            // 
            // fNum
            // 
            this.fNum.Location = new System.Drawing.Point(346, 46);
            this.fNum.Name = "fNum";
            this.fNum.Size = new System.Drawing.Size(120, 26);
            this.fNum.TabIndex = 3;
            // 
            // dNum
            // 
            this.dNum.Location = new System.Drawing.Point(346, 118);
            this.dNum.Name = "dNum";
            this.dNum.Size = new System.Drawing.Size(120, 26);
            this.dNum.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drink";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(229, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Purchase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rfidTb
            // 
            this.rfidTb.Location = new System.Drawing.Point(80, 177);
            this.rfidTb.Name = "rfidTb";
            this.rfidTb.Size = new System.Drawing.Size(220, 26);
            this.rfidTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "RFID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 35);
            this.button4.TabIndex = 11;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(30, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 204);
            this.listBox1.TabIndex = 13;
            // 
            // drinkRBtn
            // 
            this.drinkRBtn.Location = new System.Drawing.Point(655, 118);
            this.drinkRBtn.Name = "drinkRBtn";
            this.drinkRBtn.Size = new System.Drawing.Size(110, 33);
            this.drinkRBtn.TabIndex = 14;
            this.drinkRBtn.Text = "Remove";
            this.drinkRBtn.UseVisualStyleBackColor = true;
            this.drinkRBtn.Click += new System.EventHandler(this.drinkRBtn_Click);
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drinkRBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rfidTb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.fNum);
            this.Controls.Add(this.foodRBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "RestaurantForm";
            this.Text = "RestaurantForm";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button foodRBtn;
        private System.Windows.Forms.NumericUpDown fNum;
        private System.Windows.Forms.NumericUpDown dNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox rfidTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button drinkRBtn;
    }
}