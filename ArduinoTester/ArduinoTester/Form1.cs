using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoTester
{

    public partial class Form1 : Form
    {
        private Tester _tester;
        private TestResults testResults;
        private CancellationTokenSource _canceller;

        private readonly string[] digitalPins= {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11","12","13"};
        private readonly string[] analogPins = {"A0", "A1", "A2", "A3", "A4", "A5"};

        public Form1()
        {
            InitializeComponent();
            _tester = new Tester();
            testResults = new TestResults(digitalPins,analogPins);
            btn_CloseConnection.Enabled = false;
            btn_Next.Enabled = false;
            btn_PinTest.Enabled = false;

            foreach (var port in _tester.getAvailableComPorts())
            {
                cbox_ComPorts.Items.Add(port);
            }

            if (cbox_ComPorts.Items[0] != null) cbox_ComPorts.SelectedItem = cbox_ComPorts.Items[0];
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_closing(object sender, EventArgs e)
        {
            _tester.CloseSerialPort();
        }

        private void btn_Start_Test_Click(object sender, EventArgs e)
        {
            StartTest();
        }

        private void btn_OpenConnection_Click(object sender, EventArgs e)
        {
            _tester.setComPort(cbox_ComPorts.SelectedItem.ToString());
            _tester.OpenSerialPort();
            btn_CloseConnection.Enabled = true;
            btn_PinTest.Enabled = true;
            btn_Next.Enabled = true;
            btn_OpenConnection.Enabled = false;
            cbox_ComPorts.Enabled = false;
        }

        private void btn_CloseConnection_Click(object sender, EventArgs e)
        {
            _tester.CloseSerialPort();
            btn_OpenConnection.Enabled = true;
            cbox_ComPorts.Enabled = true;
        }

        private async void StartTest()
        {
            _canceller = new CancellationTokenSource();
            for (int i = 0; i < digitalPins.Length; i++)
            {
                string testPin = digitalPins[i];
                string testerPin = i + 1 == digitalPins.Length ? digitalPins[0] : digitalPins[i+1];
                //give instructions to user to connect the correct pins 
                lbl_Instructions.Text = $"Please connect pin {testPin} to pin {testerPin} using a resistor";
                btn_Next.Text = "Test";
                btn_Next.Enabled = true;
                await Task.Run(() =>
                {//wait till next button is pressed
                    do
                    {
                        if (_canceller.IsCancellationRequested) break;
                    } while (true);
                });
                string result = _tester.TestDigitalPin(testPin, testerPin);
                if (string.IsNullOrEmpty(result)){MessageBox.Show(
                        $"There was an error communicating with the device while testing pin {testPin} with {testerPin}," +
                        $" please try again", @"An Erro Has Occured",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); i--; }//show error and go back on index to retry last test
                else
                {
                    testResults.AddResultData(testPin,result.TrimStart('#').TrimEnd('%'));
                    string inResult = testResults.GetResult(testPin)[0]?"Okay":"Error";
                    string outResult = testResults.GetResult(testPin)[1]?"Okay":"Error";
                    lbl_Results.Text = $"pin {testerPin}:\nINPUT:{inResult}\nOutput{outResult}";
                }
                
            }
            for (int i = 0; i < analogPins.Length; i++)
            {
                string testPin = analogPins[i];
                string testerPin = i + 1 == analogPins.Length ? analogPins[0] : analogPins[i + 1];
                //give instructions to user to connect the correct pins 
                lbl_Instructions.Text = $"Please connect pin {testPin} to pin {testerPin} using a potentiometer," +
                                        $"\r\n and move it from its maximum value.";
                btn_Next.Text = "Test";
                btn_Next.Enabled = true;
                await Task.Run(() =>
                {//wait till next button is pressed
                    do
                    {
                        if (_canceller.IsCancellationRequested) break;
                    } while (true);
                });
                lbl_Instructions.Text = "Now move the potentiometer to its minimum value.";
                string result = _tester.TestAnalogPin(testPin, testerPin);
                if (string.IsNullOrEmpty(result)){ MessageBox.Show(
                    $"There was an error communicating with the device while testing pin {testPin} with {testerPin}," +
                    $" please try again", @"An Erro Has Occured",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);i--;}//show error and go back on index to retry last test
                else
                {
                    testResults.AddResultData(testPin, result.TrimStart('#').TrimEnd('%'));
                    string inResult = testResults.GetResult(testPin)[0] ? "Okay" : "Error";
                    string outResult = testResults.GetResult(testPin)[1] ? "Okay" : "Error";
                    lbl_Results.Text = $"pin {testerPin}:\nINPUT:{inResult}\nOutput{outResult}";
                }
            }
        }


        private void btn_Next_Click(object sender, EventArgs e)
        {
            _canceller.Cancel();
            btn_Next.Enabled = false;
        }
    }
}
