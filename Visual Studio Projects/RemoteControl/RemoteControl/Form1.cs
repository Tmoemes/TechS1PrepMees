using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RemoteControl
{
    public partial class Form1 : Form
    {
        private string _command;
        private static SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
            gbox_Control.Enabled = false;
            foreach (var port in SerialPort.GetPortNames())
            {
                cbox_ComPorts.Items.Add(port);
            }

            if (cbox_ComPorts.Items[0] != null) cbox_ComPorts.SelectedItem = cbox_ComPorts.Items[0];
        }

        private void check_LED1_CheckedChanged(object sender, EventArgs e)
        {
            _command = check_LED1.Checked ? "#SET_LED_1:ON%" : "#SET_LED_1:OFF%";
            lbl_SerialCommand.Text = _command;
            _serialPort.WriteLine(_command);
            UpdateSerialResponse();
        }

        private void check_LED2_CheckedChanged(object sender, EventArgs e)
        {
            _command = check_LED2.Checked ? "#SET_LED_2:ON%" : "#SET_LED_2:OFF%";
            lbl_SerialCommand.Text = _command;
            _serialPort.WriteLine(_command);
            UpdateSerialResponse();
        }

        private void check_LED3_CheckedChanged(object sender, EventArgs e)
        {
            _command = check_LED3.Checked ? "#SET_LED_3:ON%" : "#SET_LED_3:OFF%";
            lbl_SerialCommand.Text = _command;
            _serialPort.WriteLine(_command);
            UpdateSerialResponse();
        }

        private void btn_RGBOFF_Click(object sender, EventArgs e)
        {
            _command = "#SET_RGB_LED:OFF%";
            lbl_SerialCommand.Text = _command;
            _serialPort.WriteLine(_command);
            tbar_Red.Value = 0;
            tbar_Green.Value = 0;
            tbar_Blue.Value = 0;
            lbl_Red.Text = "0";
            lbl_Green.Text = "0";
            lbl_Blue.Text = "0";
            UpdateSerialResponse();
        }

        private void tbar_Blue_Scroll(object sender, EventArgs e)
        {
            lbl_Blue.Text = $"Blue: {tbar_Blue.Value}";
            updateRGBPreview();
        }

        private void tbar_Green_Scroll(object sender, EventArgs e)
        {
            lbl_Green.Text = $"Green: {tbar_Green.Value}";
            updateRGBPreview();
        }

        private void tbar_Red_Scroll(object sender, EventArgs e)
        {
            lbl_Red.Text = $"Red: {tbar_Red.Value}";
            updateRGBPreview();
        }

        private void updateRGBPreview()
        {
            btn_UpdateRGB.BackColor = Color.FromArgb(tbar_Red.Value,tbar_Green.Value,tbar_Blue.Value);
        }

        private void updateRGB()
        {
            _command = $"#SET_RGB_LED:RGB:{tbar_Red.Value},{tbar_Green.Value},{tbar_Blue.Value}%";
            lbl_SerialCommand.Text = _command;
            _serialPort.WriteLine(_command);
        }
        private void btn_OpenConnection_Click(object sender, EventArgs e)
        {
            _serialPort = new SerialPort(cbox_ComPorts.SelectedItem.ToString(), 9600);
            _serialPort.ReadTimeout = 5000;
            _serialPort.Open();
            gbox_Control.Enabled = true;
            btn_CloseConnection.Enabled = true;
            btn_OpenConnection.Enabled = false;
            cbox_ComPorts.Enabled = false;
        }

        private void btn_CloseConnection_Click(object sender, EventArgs e)
        {
            _serialPort.Close();
            btn_OpenConnection.Enabled = true;
            cbox_ComPorts.Enabled = true;
            gbox_Control.Enabled = false;
        }

        void UpdateSerialResponse()
        {
            string response;
            try
            {
                response = _serialPort.ReadLine();
            }
            catch (TimeoutException)
            {
                lbl_ReveivedSerial.Text = "response timedout";
                return;
            };
            if (string.IsNullOrEmpty(response)) lbl_ReveivedSerial.Text = "Something went wrong \n receiving a response.";
            lbl_ReveivedSerial.Text = response;
        }

        private void btn_UpdateRGB_Click(object sender, EventArgs e)
        {
            updateRGB();
            UpdateSerialResponse();
        }
    }
}
