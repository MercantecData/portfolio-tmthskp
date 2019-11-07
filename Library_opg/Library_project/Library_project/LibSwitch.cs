using System;
using System.Collections.Generic;
using System.Text;

namespace Library_project
{
    class LibSwitch
    {      
        LibText textSwitch = new LibText(); //Convert class LibText to an object

        /********* Book burrow Switch *********/
        public void BookBurrowSwitch(Library lib) //whilst called also send Library
        {         
            string userResponse = textSwitch.MySwitchText1(); //a new variable to use from elements collected from LibText class
            switch (userResponse.ToLower())
            {
                case "yes":
                case "y":
                    lib.BookBurrow();
                    break;

                case "no":
                case "n":
                    textSwitch.MySwitchText2();
                    break;

                default:
                    textSwitch.MySwitchText3();                   
                    BookBurrowSwitch(lib);
                    break;
            }
        }

        /********* Book return switch *********/
        public void BookReturnSwitch(Library lib)
        {
            string userResponse1 = textSwitch.MySwitchText4();
            switch (userResponse1.ToLower())
            {
                case "yes":
                case "y":
                    lib.BookReturn();
                    break;

                case "no":
                case "n":

                    ExtendBurrowTimeSwitch(lib);
                    break;

                default:
                    textSwitch.MySwitchText5();                 
                    BookReturnSwitch(lib);
                    break;
            }
        }

        /********* Burrow time extend switch *********/
        public void ExtendBurrowTimeSwitch(Library lib)
        {

            string userResponse2 = textSwitch.MySwitchText6();
            switch (userResponse2.ToLower())
            {
                case "yes":
                case "y":
                    
                    string extendTime = textSwitch.MySwitchText7();
                    try
                    {
                        lib.burrowTime = Convert.ToInt32(extendTime);
                        textSwitch.MySwitchText8(lib);
                    }
                    catch (FormatException)
                    {
                        textSwitch.MySwitchText9();
                        ExtendBurrowTimeSwitch(lib);
                    }
                    break;

                case "no":
                case "n":
                    textSwitch.MySwitchText10();
                    break;

                default:
                    textSwitch.MySwitchText11();                   
                    ExtendBurrowTimeSwitch(lib);
                    break;
            }
        }

    }
}
