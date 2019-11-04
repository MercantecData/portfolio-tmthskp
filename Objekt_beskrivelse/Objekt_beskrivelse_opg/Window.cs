using System;
using System.Collections.Generic;
using System.Text;

namespace Objekt_beskrivelse_opg
{
    class Window
    {

        public string Transperency;
        public string Surface;
        public string Shape;
        public string Reflective;
        public string Attached;

        public string MyWindow()
        {
            string myWindow = "Window is " + Transperency + " It got a " + Surface + " The Shape is " + Shape + " It is " + Reflective + " It is Attached " + Attached;

            return myWindow;
        }

    }
}
