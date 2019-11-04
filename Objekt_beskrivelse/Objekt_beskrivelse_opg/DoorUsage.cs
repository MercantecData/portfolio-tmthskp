using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class DoorUsage
    {
        public string Open;
        public string Close;
        public string Lock;
        public string OpenLock;
        public string Smash;

        public string MyDoorUsage()
        {
            string doorUsage = "My door can " + Open + " and it can " + Close + " The lock can " + Lock + " it can also " + OpenLock + " The door can also be " + Smash;
            return doorUsage;
        }
    }
}
