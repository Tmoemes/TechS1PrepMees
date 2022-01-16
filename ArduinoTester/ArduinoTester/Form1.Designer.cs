namespace ArduinoTester
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
            this.btn_PinTest = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_Results = new System.Windows.Forms.Label();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.cbox_ComPorts = new System.Windows.Forms.ComboBox();
            this.btn_OpenConnection = new System.Windows.Forms.Button();
            this.btn_CloseConnection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PinTest
            // 
            this.btn_PinTest.Location = new System.Drawing.Point(136, 270);
            this.btn_PinTest.Name = "btn_PinTest";
            this.btn_PinTest.Size = new System.Drawing.Size(85, 23);
            this.btn_PinTest.TabIndex = 1;
            this.btn_PinTest.Text = "Start Pin Test";
            this.btn_PinTest.UseVisualStyleBackColor = true;
            this.btn_PinTest.Click += new System.EventHandler(this.btn_Start_Test_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(385, 270);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(76, 23);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Test";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_Results
            // 
            this.lbl_Results.AutoSize = true;
            this.lbl_Results.Location = new System.Drawing.Point(250, 64);
            this.lbl_Results.Name = "lbl_Results";
            this.lbl_Results.Size = new System.Drawing.Size(44, 15);
            this.lbl_Results.TabIndex = 3;
            this.lbl_Results.Text = "Results";
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Location = new System.Drawing.Point(250, 171);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(69, 15);
            this.lbl_Instructions.TabIndex = 4;
            this.lbl_Instructions.Text = "Instructions";
            // 
            // cbox_ComPorts
            // 
            this.cbox_ComPorts.FormattingEnabled = true;
            this.cbox_ComPorts.Location = new System.Drawing.Point(58, 39);
            this.cbox_ComPorts.Name = "cbox_ComPorts";
            this.cbox_ComPorts.Size = new System.Drawing.Size(121, 23);
            this.cbox_ComPorts.TabIndex = 5;
            // 
            // btn_OpenConnection
            // 
            this.btn_OpenConnection.Location = new System.Drawing.Point(250, 39);
            this.btn_OpenConnection.Name = "btn_OpenConnection";
            this.btn_OpenConnection.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenConnection.TabIndex = 6;
            this.btn_OpenConnection.Text = "Open";
            this.btn_OpenConnection.UseVisualStyleBackColor = true;
            this.btn_OpenConnection.Click += new System.EventHandler(this.btn_OpenConnection_Click);
            // 
            // btn_CloseConnection
            // 
            this.btn_CloseConnection.Location = new System.Drawing.Point(385, 38);
            this.btn_CloseConnection.Name = "btn_CloseConnection";
            this.btn_CloseConnection.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseConnection.TabIndex = 7;
            this.btn_CloseConnection.Text = "Close";
            this.btn_CloseConnection.UseVisualStyleBackColor = true;
            this.btn_CloseConnection.Click += new System.EventHandler(this.btn_CloseConnection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_ComPorts);
            this.groupBox1.Controls.Add(this.btn_OpenConnection);
            this.groupBox1.Controls.Add(this.btn_CloseConnection);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_PinTest);
            this.groupBox2.Controls.Add(this.btn_Next);
            this.groupBox2.Controls.Add(this.lbl_Results);
            this.groupBox2.Controls.Add(this.lbl_Instructions);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 328);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tester";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Start Pin Test";
            this.Closed += new System.EventHandler(this.Form1_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_PinTest;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_Results;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.ComboBox cbox_ComPorts;
        private System.Windows.Forms.Button btn_OpenConnection;
        private System.Windows.Forms.Button btn_CloseConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

