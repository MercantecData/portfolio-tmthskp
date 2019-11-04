using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class DoorDescription
    {
        public string Surface;
        public string Handle;
        public string KeyHole;
        public string Color;
        public string Attached;

        public string MyDoorDescription()
        {
            string doorDescription = "My door is coated with a gray " + Color + " It got a " + Handle + " It also have a " + KeyHole + " The Door got a Matte " + Surface + " It is  " + Attached + " on a Wall ";
            return doorDescription;
        }
    }
}
