using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArduinoTester
{
    class TestResults
    {
        private string[] _ioPins;
        private bool[] _outResults;
        private bool[] _inResults;
        

        public TestResults(string[] digitalPins, string[] analogPins)
        {   //setup the arrays to save the values, maybe make another object for pins but probably be overkill
            _ioPins = (string[]) digitalPins.Concat(analogPins);
            _outResults = new bool[_ioPins.Length];
            _inResults = new bool[_ioPins.Length];
        }

        public void AddResultData(string pin, string input)
        {
            int index = Array.IndexOf(_ioPins, pin);
            _inResults[index] = bool.Parse(input.Split(',')[0]);
            _outResults[index] = bool.Parse(input.Split(',')[1]);
        }
        public bool[] GetResult(string pin)
        {
            int index = Array.IndexOf(_ioPins, pin);
            return new[] {_inResults[index], _outResults[index]};
        }

        public string GetTotalResultsString()//creates a formatted string of all the results in a 2 wide column
        {
            string totalResults = "The total result of this board is:\n";
            for (int i = 0; i < _ioPins.Length; i+=2)
            {
                string inResult = _inResults[i] ? "Okay" : "Error";
                string outResult = _outResults[i] ? "Okay" : "Error";
                totalResults += $"Pin {_ioPins[i]}: INPUT {inResult}, OUTPUT {outResult}";
                if (i + 1 != _ioPins.Length)//check to keep from going out of array bounds
                {
                    inResult = _inResults[i+1] ? "Okay" : "Error";
                    outResult = _outResults[i+1] ? "Okay" : "Error";
                    totalResults += $"Pin {_ioPins[i]}: INPUT {inResult}, OUTPUT {outResult}\n";
                }
            }

            return totalResults;
        }
    }
}
