using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class ElevatorLiftDesription
    {
        public string Surface;
        public string Display;
        public string Button;
        public string Doors;
        public string Metal;

        public string MyElevatorLiftDescription()
        {
            string elevatorLiftDescription = "My Lift got a smooth " + Surface + " It got a " + Display + " It Got a " + Button + " It got some " + Doors + " and made of " + Metal;
            return elevatorLiftDescription;
        }
    }
}

