using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace ArduinoTester
{
    class Tester
    {
        private static SerialPort _serialPort;
        private string result;

        public Tester()
        {

        }

        public String[] getAvailableComPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void setComPort(string comPort)
        {
            _serialPort = new SerialPort(comPort, 9600);
        }

        public string TestDigitalPin(string testPin, string testerPin)
        {
            _serialPort.Write($"#Test_Pins:%{testPin},{testerPin}");
            if (_serialPort.ReadLine() != "#Pin_Test_Starting%") return null;
            return _serialPort.ReadLine();
        }

        public string TestAnalogPin(string testPin, string testerPin)
        {
            _serialPort.Write($"#Test_Analog_Pins:%{testPin},{testerPin}");
            if (_serialPort.ReadLine() != "#Analog_Pin_Test_Starting%") return null;
            return _serialPort.ReadLine();
        }

        public void CloseSerialPort()
        {
            _serialPort.Close();
        }

        public void OpenSerialPort()
        {
            _serialPort.Open();
        }
    }
}
