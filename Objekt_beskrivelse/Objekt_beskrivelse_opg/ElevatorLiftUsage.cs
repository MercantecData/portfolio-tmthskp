using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class ElevatorLiftUsage
    {
        public string Contain;
        public string CanOpen;
        public string Transport;
        public string UpDown;
        public string Input;

        public string MyElevatorLiftUsage()
        {
            string elevatorLiftUsage = "My Lift can " + Contain + " Several people, it got doors that " + CanOpen + " It can " + Transport + " people " + UpDown + " The Lift can also retrieve " + Input;
            return elevatorLiftUsage;
        }
    }
}

