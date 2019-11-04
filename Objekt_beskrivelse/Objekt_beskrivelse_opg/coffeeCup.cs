using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class CoffeeCup
    {
        public string Color;
        public string Material;
        public string Surface;
        public string TopMaterial;
        public string LockMaterial;

        public string CupDescription()
        {
            string cupDescription1 = "My cup color is " + Color + " Made primary of " + Material + " But someparts are made of " + TopMaterial + " The Surface is " + Surface + " The lock is also made of " + LockMaterial;

            return cupDescription1;
        }
        
    }
}
