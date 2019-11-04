using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class CupUsage
    {
        public string Contain;
        public string Thermo;
        public string Open;
        public string Close;
        public string Drink;

        public string CupUsage1()
        {
            string cupUsage2 = "My cup can contain " + Contain + " My cup can " + Thermo + " You can " + Drink + Open + Close;

            return cupUsage2;
        }

    }
}
