using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1._3_BankAccount
{
    public class TrafficLight
    {
        private enum lightColour{red,orange,green}

        private lightColour lightState;

        public TrafficLight()
        {
            lightState = lightColour.red;
        }

        public void startLightCycle()
        {

        }

    }
}
