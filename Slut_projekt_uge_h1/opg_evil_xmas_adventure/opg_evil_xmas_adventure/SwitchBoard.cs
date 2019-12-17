using System;


namespace opg_evil_xmas_adventure
{
    class SwitchBoard
    {
        Obstacles obstacles = new Obstacles();
       

       public void TwoPaths() //TwoPaths Switch
       {
            Console.WriteLine("\nAs you look down the forrest walkway. \nHidden in the middle of the thick trees you notice two paths that you can choose from");
            Console.WriteLine("\nDo you take the path to the right? \nOr The Path to the left? \nMaybe you wanna turnback and end your adventuring days right there?");
            Console.WriteLine("\nLeft? \nRight? \nTurnback?");
            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "left":
                    Console.WriteLine("\nA True Hero always Turn Right first");
                    TwoPaths();
                    break;

                case "right":
                    //EncounterSound();
                    Console.WriteLine("\nYou walk proudly for a few minutes when suddently.");
                    obstacles.AnObstacle();
                    break;

                case "turnback":
                    //RunAwaySound();
                    Console.WriteLine("\nYou Decide that this is enough adventuring for today. \nSo you turn back and End the game");
                    break;

                default:
                    Console.WriteLine("I'm sorry, I didn't understand that!");
                    TwoPaths();
                    break;
            }           
       }

    }
}
