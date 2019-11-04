using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class SignDescription
    {
        public string Stability;
        public string Color;
        public string Text;
        public string Material;
        public string Standing;

        public string MySign()
        {
            string mySign = "It is " + Stability + " Its color is " + Color + " There are " + Text + " It is made of " + Material + " It is not sitting " + Standing;
            return mySign;
        }
    }
}

