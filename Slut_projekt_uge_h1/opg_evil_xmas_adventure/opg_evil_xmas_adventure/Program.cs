using System;


namespace opg_evil_xmas_adventure
{
    class Program
    {
        

        /*  -------------------------- Main Code ------------------------------- */
        static void Main(string[] args)
        {               
            TextMethods textMethods = new TextMethods();
            SwitchBoard switchBoard = new SwitchBoard();

            //GameTitle
            textMethods.GameTitle();

            //StartGameText Method            
            Console.WriteLine(textMethods.StartGameText());
            Console.WriteLine("");

            bool gameloop = true;
            while(gameloop)
            { 
                //TwoPaths Function
                switchBoard.TwoPaths();

                //AfterVictory Method
                Console.WriteLine(textMethods.ContinueOn());
            }
        }

    }
}
