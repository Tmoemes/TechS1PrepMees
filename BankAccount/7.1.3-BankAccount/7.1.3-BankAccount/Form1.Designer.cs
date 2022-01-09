namespace _7._1._3_BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Deposit1 = new System.Windows.Forms.Button();
            this.gbox_Account1 = new System.Windows.Forms.GroupBox();
            this.lbl_Balance1Value = new System.Windows.Forms.Label();
            this.btn_Transfer1 = new System.Windows.Forms.Button();
            this.lbl_Saldo1 = new System.Windows.Forms.Label();
            this.btn_Withdraw1 = new System.Windows.Forms.Button();
            this.txtbox_Input = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_Balance2Value = new System.Windows.Forms.Label();
            this.btn_Transfer2 = new System.Windows.Forms.Button();
            this.lbl_Saldo2 = new System.Windows.Forms.Label();
            this.btn_Withdraw2 = new System.Windows.Forms.Button();
            this.btn_Deposit2 = new System.Windows.Forms.Button();
            this.gbox_Account2 = new System.Windows.Forms.GroupBox();
            this.gbox_Account1.SuspendLayout();
            this.gbox_Account2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Deposit1
            // 
            this.btn_Deposit1.Location = new System.Drawing.Point(30, 104);
            this.btn_Deposit1.Name = "btn_Deposit1";
            this.btn_Deposit1.Size = new System.Drawing.Size(85, 26);
            this.btn_Deposit1.TabIndex = 0;
            this.btn_Deposit1.Text = "Storten";
            this.btn_Deposit1.UseVisualStyleBackColor = true;
            this.btn_Deposit1.Click += new System.EventHandler(this.btn_Deposit1_Click);
            // 
            // gbox_Account1
            // 
            this.gbox_Account1.Controls.Add(this.lbl_Balance1Value);
            this.gbox_Account1.Controls.Add(this.btn_Transfer1);
            this.gbox_Account1.Controls.Add(this.lbl_Saldo1);
            this.gbox_Account1.Controls.Add(this.btn_Withdraw1);
            this.gbox_Account1.Controls.Add(this.btn_Deposit1);
            this.gbox_Account1.Location = new System.Drawing.Point(12, 12);
            this.gbox_Account1.Name = "gbox_Account1";
            this.gbox_Account1.Size = new System.Drawing.Size(192, 243);
            this.gbox_Account1.TabIndex = 1;
            this.gbox_Account1.TabStop = false;
            this.gbox_Account1.Text = "Account";
            // 
            // lbl_Balance1Value
            // 
            this.lbl_Balance1Value.AutoSize = true;
            this.lbl_Balance1Value.Location = new System.Drawing.Point(84, 60);
            this.lbl_Balance1Value.Name = "lbl_Balance1Value";
            this.lbl_Balance1Value.Size = new System.Drawing.Size(13, 15);
            this.lbl_Balance1Value.TabIndex = 4;
            this.lbl_Balance1Value.Text = "1";
            // 
            // btn_Transfer1
            // 
            this.btn_Transfer1.Location = new System.Drawing.Point(30, 187);
            this.btn_Transfer1.Name = "btn_Transfer1";
            this.btn_Transfer1.Size = new System.Drawing.Size(85, 26);
            this.btn_Transfer1.TabIndex = 0;
            this.btn_Transfer1.Text = "Overmaken";
            this.btn_Transfer1.UseVisualStyleBackColor = true;
            this.btn_Transfer1.Click += new System.EventHandler(this.btn_Transfer1_Click);
            // 
            // lbl_Saldo1
            // 
            this.lbl_Saldo1.AutoSize = true;
            this.lbl_Saldo1.Location = new System.Drawing.Point(30, 60);
            this.lbl_Saldo1.Name = "lbl_Saldo1";
            this.lbl_Saldo1.Size = new System.Drawing.Size(39, 15);
            this.lbl_Saldo1.TabIndex = 3;
            this.lbl_Saldo1.Text = "Saldo:";
            // 
            // btn_Withdraw1
            // 
            this.btn_Withdraw1.Location = new System.Drawing.Point(30, 145);
            this.btn_Withdraw1.Name = "btn_Withdraw1";
            this.btn_Withdraw1.Size = new System.Drawing.Size(85, 27);
            this.btn_Withdraw1.TabIndex = 0;
            this.btn_Withdraw1.Text = "Opnemen";
            this.btn_Withdraw1.UseVisualStyleBackColor = true;
            this.btn_Withdraw1.Click += new System.EventHandler(this.btn_Withdraw1_Click);
            // 
            // txtbox_Input
            // 
            this.txtbox_Input.Location = new System.Drawing.Point(212, 274);
            this.txtbox_Input.Name = "txtbox_Input";
            this.txtbox_Input.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Input.TabIndex = 2;
            this.txtbox_Input.TextChanged += new System.EventHandler(this.txtbox_Input_TextChanged);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(161, 277);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(43, 15);
            this.lbl_input.TabIndex = 4;
            this.lbl_input.Text = "Invoer:";
            // 
            // lbl_Balance2Value
            // 
            this.lbl_Balance2Value.AutoSize = true;
            this.lbl_Balance2Value.Location = new System.Drawing.Point(84, 60);
            this.lbl_Balance2Value.Name = "lbl_Balance2Value";
            this.lbl_Balance2Value.Size = new System.Drawing.Size(13, 15);
            this.lbl_Balance2Value.TabIndex = 4;
            this.lbl_Balance2Value.Text = "0";
            // 
            // btn_Transfer2
            // 
            this.btn_Transfer2.Location = new System.Drawing.Point(30, 187);
            this.btn_Transfer2.Name = "btn_Transfer2";
            this.btn_Transfer2.Size = new System.Drawing.Size(85, 26);
            this.btn_Transfer2.TabIndex = 0;
            this.btn_Transfer2.Text = "Overmaken";
            this.btn_Transfer2.UseVisualStyleBackColor = true;
            this.btn_Transfer2.Click += new System.EventHandler(this.btn_Transfer2_Click);
            // 
            // lbl_Saldo2
            // 
            this.lbl_Saldo2.AutoSize = true;
            this.lbl_Saldo2.Location = new System.Drawing.Point(30, 60);
            this.lbl_Saldo2.Name = "lbl_Saldo2";
            this.lbl_Saldo2.Size = new System.Drawing.Size(39, 15);
            this.lbl_Saldo2.TabIndex = 3;
            this.lbl_Saldo2.Text = "Saldo:";
            // 
            // btn_Withdraw2
            // 
            this.btn_Withdraw2.Location = new System.Drawing.Point(30, 145);
            this.btn_Withdraw2.Name = "btn_Withdraw2";
            this.btn_Withdraw2.Size = new System.Drawing.Size(85, 27);
            this.btn_Withdraw2.TabIndex = 0;
            this.btn_Withdraw2.Text = "Opnemen";
            this.btn_Withdraw2.UseVisualStyleBackColor = true;
            this.btn_Withdraw2.Click += new System.EventHandler(this.btn_Withdraw2_Click);
            // 
            // btn_Deposit2
            // 
            this.btn_Deposit2.Location = new System.Drawing.Point(30, 104);
            this.btn_Deposit2.Name = "btn_Deposit2";
            this.btn_Deposit2.Size = new System.Drawing.Size(85, 26);
            this.btn_Deposit2.TabIndex = 0;
            this.btn_Deposit2.Text = "Storten";
            this.btn_Deposit2.UseVisualStyleBackColor = true;
            this.btn_Deposit2.Click += new System.EventHandler(this.btn_Deposit2_Click);
            // 
            // gbox_Account2
            // 
            this.gbox_Account2.Controls.Add(this.lbl_Balance2Value);
            this.gbox_Account2.Controls.Add(this.btn_Transfer2);
            this.gbox_Account2.Controls.Add(this.lbl_Saldo2);
            this.gbox_Account2.Controls.Add(this.btn_Withdraw2);
            this.gbox_Account2.Controls.Add(this.btn_Deposit2);
            this.gbox_Account2.Location = new System.Drawing.Point(220, 12);
            this.gbox_Account2.Name = "gbox_Account2";
            this.gbox_Account2.Size = new System.Drawing.Size(192, 243);
            this.gbox_Account2.TabIndex = 1;
            this.gbox_Account2.TabStop = false;
            this.gbox_Account2.Text = "Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.gbox_Account2);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.txtbox_Input);
            this.Controls.Add(this.gbox_Account1);
            this.Name = "Form1";
            this.Text = "Invoer:";
            this.gbox_Account1.ResumeLayout(false);
            this.gbox_Account1.PerformLayout();
            this.gbox_Account2.ResumeLayout(false);
            this.gbox_Account2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_Account1;
        private System.Windows.Forms.Button btn_Deposit1;
        private System.Windows.Forms.Button btn_Transfer1;
        private System.Windows.Forms.Button btn_Withdraw1;
        private System.Windows.Forms.Label lbl_Saldo1;
        private System.Windows.Forms.TextBox txtbox_Input;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_Balance1Value;
        private System.Windows.Forms.Label lbl_Balance2Value;
        private System.Windows.Forms.Button btn_Transfer2;
        private System.Windows.Forms.Label lbl_Saldo2;
        private System.Windows.Forms.Button btn_Withdraw2;
        private System.Windows.Forms.Button btn_Deposit2;
        private System.Windows.Forms.GroupBox gbox_Account2;
    }
}

