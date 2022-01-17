namespace RemoteControl
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
            this.gbox_Control = new System.Windows.Forms.GroupBox();
            this.lbl_SerialCommand = new System.Windows.Forms.Label();
            this.gbox_RGBLED = new System.Windows.Forms.GroupBox();
            this.btn_UpdateRGB = new System.Windows.Forms.Button();
            this.btn_RGBOFF = new System.Windows.Forms.Button();
            this.lbl_Blue = new System.Windows.Forms.Label();
            this.lbl_Green = new System.Windows.Forms.Label();
            this.lbl_Red = new System.Windows.Forms.Label();
            this.tbar_Blue = new System.Windows.Forms.TrackBar();
            this.tbar_Green = new System.Windows.Forms.TrackBar();
            this.tbar_Red = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.check_LED3 = new System.Windows.Forms.CheckBox();
            this.check_LED2 = new System.Windows.Forms.CheckBox();
            this.check_LED1 = new System.Windows.Forms.CheckBox();
            this.gbox_Connection = new System.Windows.Forms.GroupBox();
            this.btn_CloseConnection = new System.Windows.Forms.Button();
            this.btn_OpenConnection = new System.Windows.Forms.Button();
            this.cbox_ComPorts = new System.Windows.Forms.ComboBox();
            this.lbl_SerialText = new System.Windows.Forms.Label();
            this.lbl_SerialReceiveText = new System.Windows.Forms.Label();
            this.lbl_ReveivedSerial = new System.Windows.Forms.Label();
            this.gbox_Control.SuspendLayout();
            this.gbox_RGBLED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Red)).BeginInit();
            this.gbox_Connection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_Control
            // 
            this.gbox_Control.Controls.Add(this.lbl_ReveivedSerial);
            this.gbox_Control.Controls.Add(this.lbl_SerialReceiveText);
            this.gbox_Control.Controls.Add(this.lbl_SerialText);
            this.gbox_Control.Controls.Add(this.lbl_SerialCommand);
            this.gbox_Control.Controls.Add(this.gbox_RGBLED);
            this.gbox_Control.Controls.Add(this.label1);
            this.gbox_Control.Controls.Add(this.check_LED3);
            this.gbox_Control.Controls.Add(this.check_LED2);
            this.gbox_Control.Controls.Add(this.check_LED1);
            this.gbox_Control.Location = new System.Drawing.Point(12, 12);
            this.gbox_Control.Name = "gbox_Control";
            this.gbox_Control.Size = new System.Drawing.Size(608, 294);
            this.gbox_Control.TabIndex = 0;
            this.gbox_Control.TabStop = false;
            this.gbox_Control.Text = "Led Control";
            // 
            // lbl_SerialCommand
            // 
            this.lbl_SerialCommand.AutoSize = true;
            this.lbl_SerialCommand.Location = new System.Drawing.Point(16, 181);
            this.lbl_SerialCommand.Name = "lbl_SerialCommand";
            this.lbl_SerialCommand.Size = new System.Drawing.Size(92, 15);
            this.lbl_SerialCommand.TabIndex = 5;
            this.lbl_SerialCommand.Text = "serial command";
            // 
            // gbox_RGBLED
            // 
            this.gbox_RGBLED.Controls.Add(this.btn_UpdateRGB);
            this.gbox_RGBLED.Controls.Add(this.btn_RGBOFF);
            this.gbox_RGBLED.Controls.Add(this.lbl_Blue);
            this.gbox_RGBLED.Controls.Add(this.lbl_Green);
            this.gbox_RGBLED.Controls.Add(this.lbl_Red);
            this.gbox_RGBLED.Controls.Add(this.tbar_Blue);
            this.gbox_RGBLED.Controls.Add(this.tbar_Green);
            this.gbox_RGBLED.Controls.Add(this.tbar_Red);
            this.gbox_RGBLED.Location = new System.Drawing.Point(176, 22);
            this.gbox_RGBLED.Name = "gbox_RGBLED";
            this.gbox_RGBLED.Size = new System.Drawing.Size(421, 266);
            this.gbox_RGBLED.TabIndex = 4;
            this.gbox_RGBLED.TabStop = false;
            this.gbox_RGBLED.Text = "RGB LED";
            // 
            // btn_UpdateRGB
            // 
            this.btn_UpdateRGB.Location = new System.Drawing.Point(210, 215);
            this.btn_UpdateRGB.Name = "btn_UpdateRGB";
            this.btn_UpdateRGB.Size = new System.Drawing.Size(83, 33);
            this.btn_UpdateRGB.TabIndex = 3;
            this.btn_UpdateRGB.Text = "Update RGB";
            this.btn_UpdateRGB.UseVisualStyleBackColor = true;
            this.btn_UpdateRGB.Click += new System.EventHandler(this.btn_UpdateRGB_Click);
            // 
            // btn_RGBOFF
            // 
            this.btn_RGBOFF.Location = new System.Drawing.Point(26, 215);
            this.btn_RGBOFF.Name = "btn_RGBOFF";
            this.btn_RGBOFF.Size = new System.Drawing.Size(75, 33);
            this.btn_RGBOFF.TabIndex = 2;
            this.btn_RGBOFF.Text = "OFF";
            this.btn_RGBOFF.UseVisualStyleBackColor = true;
            this.btn_RGBOFF.Click += new System.EventHandler(this.btn_RGBOFF_Click);
            // 
            // lbl_Blue
            // 
            this.lbl_Blue.AutoSize = true;
            this.lbl_Blue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Blue.Location = new System.Drawing.Point(26, 168);
            this.lbl_Blue.Name = "lbl_Blue";
            this.lbl_Blue.Size = new System.Drawing.Size(43, 21);
            this.lbl_Blue.TabIndex = 1;
            this.lbl_Blue.Text = "Blue:";
            // 
            // lbl_Green
            // 
            this.lbl_Green.AutoSize = true;
            this.lbl_Green.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Green.Location = new System.Drawing.Point(26, 105);
            this.lbl_Green.Name = "lbl_Green";
            this.lbl_Green.Size = new System.Drawing.Size(55, 21);
            this.lbl_Green.TabIndex = 1;
            this.lbl_Green.Text = "Green:";
            // 
            // lbl_Red
            // 
            this.lbl_Red.AutoSize = true;
            this.lbl_Red.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Red.Location = new System.Drawing.Point(26, 41);
            this.lbl_Red.Name = "lbl_Red";
            this.lbl_Red.Size = new System.Drawing.Size(40, 21);
            this.lbl_Red.TabIndex = 1;
            this.lbl_Red.Text = "Red:";
            // 
            // tbar_Blue
            // 
            this.tbar_Blue.Location = new System.Drawing.Point(103, 168);
            this.tbar_Blue.Maximum = 255;
            this.tbar_Blue.Name = "tbar_Blue";
            this.tbar_Blue.Size = new System.Drawing.Size(299, 45);
            this.tbar_Blue.TabIndex = 0;
            this.tbar_Blue.Scroll += new System.EventHandler(this.tbar_Blue_Scroll);
            // 
            // tbar_Green
            // 
            this.tbar_Green.Location = new System.Drawing.Point(103, 105);
            this.tbar_Green.Maximum = 255;
            this.tbar_Green.Name = "tbar_Green";
            this.tbar_Green.Size = new System.Drawing.Size(299, 45);
            this.tbar_Green.TabIndex = 0;
            this.tbar_Green.Scroll += new System.EventHandler(this.tbar_Green_Scroll);
            // 
            // tbar_Red
            // 
            this.tbar_Red.Location = new System.Drawing.Point(103, 41);
            this.tbar_Red.Maximum = 255;
            this.tbar_Red.Name = "tbar_Red";
            this.tbar_Red.Size = new System.Drawing.Size(299, 45);
            this.tbar_Red.TabIndex = 0;
            this.tbar_Red.Scroll += new System.EventHandler(this.tbar_Red_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "White LEDs";
            // 
            // check_LED3
            // 
            this.check_LED3.AutoSize = true;
            this.check_LED3.Location = new System.Drawing.Point(6, 114);
            this.check_LED3.Name = "check_LED3";
            this.check_LED3.Size = new System.Drawing.Size(55, 19);
            this.check_LED3.TabIndex = 2;
            this.check_LED3.Text = "LED 3";
            this.check_LED3.UseVisualStyleBackColor = true;
            this.check_LED3.CheckedChanged += new System.EventHandler(this.check_LED3_CheckedChanged);
            // 
            // check_LED2
            // 
            this.check_LED2.AutoSize = true;
            this.check_LED2.Location = new System.Drawing.Point(6, 89);
            this.check_LED2.Name = "check_LED2";
            this.check_LED2.Size = new System.Drawing.Size(55, 19);
            this.check_LED2.TabIndex = 1;
            this.check_LED2.Text = "LED 2";
            this.check_LED2.UseVisualStyleBackColor = true;
            this.check_LED2.CheckedChanged += new System.EventHandler(this.check_LED2_CheckedChanged);
            // 
            // check_LED1
            // 
            this.check_LED1.AutoSize = true;
            this.check_LED1.Location = new System.Drawing.Point(6, 63);
            this.check_LED1.Name = "check_LED1";
            this.check_LED1.Size = new System.Drawing.Size(55, 19);
            this.check_LED1.TabIndex = 0;
            this.check_LED1.Text = "LED 1";
            this.check_LED1.UseVisualStyleBackColor = true;
            this.check_LED1.CheckedChanged += new System.EventHandler(this.check_LED1_CheckedChanged);
            // 
            // gbox_Connection
            // 
            this.gbox_Connection.Controls.Add(this.btn_CloseConnection);
            this.gbox_Connection.Controls.Add(this.btn_OpenConnection);
            this.gbox_Connection.Controls.Add(this.cbox_ComPorts);
            this.gbox_Connection.Location = new System.Drawing.Point(12, 313);
            this.gbox_Connection.Name = "gbox_Connection";
            this.gbox_Connection.Size = new System.Drawing.Size(597, 63);
            this.gbox_Connection.TabIndex = 1;
            this.gbox_Connection.TabStop = false;
            this.gbox_Connection.Text = "Connection";
            // 
            // btn_CloseConnection
            // 
            this.btn_CloseConnection.Location = new System.Drawing.Point(449, 22);
            this.btn_CloseConnection.Name = "btn_CloseConnection";
            this.btn_CloseConnection.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseConnection.TabIndex = 2;
            this.btn_CloseConnection.Text = "Close";
            this.btn_CloseConnection.UseVisualStyleBackColor = true;
            this.btn_CloseConnection.Click += new System.EventHandler(this.btn_CloseConnection_Click);
            // 
            // btn_OpenConnection
            // 
            this.btn_OpenConnection.Location = new System.Drawing.Point(279, 22);
            this.btn_OpenConnection.Name = "btn_OpenConnection";
            this.btn_OpenConnection.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenConnection.TabIndex = 1;
            this.btn_OpenConnection.Text = "Open";
            this.btn_OpenConnection.UseVisualStyleBackColor = true;
            this.btn_OpenConnection.Click += new System.EventHandler(this.btn_OpenConnection_Click);
            // 
            // cbox_ComPorts
            // 
            this.cbox_ComPorts.FormattingEnabled = true;
            this.cbox_ComPorts.Location = new System.Drawing.Point(35, 23);
            this.cbox_ComPorts.Name = "cbox_ComPorts";
            this.cbox_ComPorts.Size = new System.Drawing.Size(121, 23);
            this.cbox_ComPorts.TabIndex = 0;
            // 
            // lbl_SerialText
            // 
            this.lbl_SerialText.AutoSize = true;
            this.lbl_SerialText.Location = new System.Drawing.Point(16, 157);
            this.lbl_SerialText.Name = "lbl_SerialText";
            this.lbl_SerialText.Size = new System.Drawing.Size(64, 15);
            this.lbl_SerialText.TabIndex = 6;
            this.lbl_SerialText.Text = "Sent Serial:";
            // 
            // lbl_SerialReceiveText
            // 
            this.lbl_SerialReceiveText.AutoSize = true;
            this.lbl_SerialReceiveText.Location = new System.Drawing.Point(16, 211);
            this.lbl_SerialReceiveText.Name = "lbl_SerialReceiveText";
            this.lbl_SerialReceiveText.Size = new System.Drawing.Size(88, 15);
            this.lbl_SerialReceiveText.TabIndex = 7;
            this.lbl_SerialReceiveText.Text = "Received Serial:";
            // 
            // lbl_ReveivedSerial
            // 
            this.lbl_ReveivedSerial.AutoSize = true;
            this.lbl_ReveivedSerial.Location = new System.Drawing.Point(16, 237);
            this.lbl_ReveivedSerial.Name = "lbl_ReveivedSerial";
            this.lbl_ReveivedSerial.Size = new System.Drawing.Size(74, 15);
            this.lbl_ReveivedSerial.TabIndex = 8;
            this.lbl_ReveivedSerial.Text = "serial receive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 387);
            this.Controls.Add(this.gbox_Connection);
            this.Controls.Add(this.gbox_Control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbox_Control.ResumeLayout(false);
            this.gbox_Control.PerformLayout();
            this.gbox_RGBLED.ResumeLayout(false);
            this.gbox_RGBLED.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_Red)).EndInit();
            this.gbox_Connection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_Control;
        private System.Windows.Forms.GroupBox gbox_Connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_LED3;
        private System.Windows.Forms.CheckBox check_LED2;
        private System.Windows.Forms.CheckBox check_LED1;
        private System.Windows.Forms.Button btn_CloseConnection;
        private System.Windows.Forms.Button btn_OpenConnection;
        private System.Windows.Forms.ComboBox cbox_ComPorts;
        private System.Windows.Forms.GroupBox gbox_RGBLED;
        private System.Windows.Forms.Button btn_RGBOFF;
        private System.Windows.Forms.Label lbl_Blue;
        private System.Windows.Forms.Label lbl_Green;
        private System.Windows.Forms.Label lbl_Red;
        private System.Windows.Forms.TrackBar tbar_Blue;
        private System.Windows.Forms.TrackBar tbar_Green;
        private System.Windows.Forms.TrackBar tbar_Red;
        private System.Windows.Forms.Label lbl_SerialCommand;
        private System.Windows.Forms.Button btn_UpdateRGB;
        private System.Windows.Forms.Label lbl_ReveivedSerial;
        private System.Windows.Forms.Label lbl_SerialReceiveText;
        private System.Windows.Forms.Label lbl_SerialText;
    }
}

