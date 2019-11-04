using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class WindowUsage
    {
        public string Smash;
        public string SeeThrough;
        public string Iluminate;
        public string HeatCold;
        public string Polish;

        public string MyWindowUsage()
        {
            string myWindowUsage = "Window can be " + Smash + " It is transperent/ " + SeeThrough + " It can let in " + Iluminate + " It can for some part protect against " + HeatCold + " It can be made shiny by " + Polish;

            return myWindowUsage;
        }
    }
}
