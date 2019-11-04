using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class SignUsage
    {
        public string Look;
        public string Read;
        public string Sit;
        public string Info;
        public string Smash;

        public string MySignUsage()
        {
            string mySignUsage = "You can " + Look + " You can " + Read + " it, You can " + Sit + " You can get " + Info + " from It and " + Smash + " it";

            return mySignUsage;
        }
    }
}
