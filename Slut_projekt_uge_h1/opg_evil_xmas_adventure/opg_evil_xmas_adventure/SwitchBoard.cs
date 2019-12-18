using System;


namespace opg_evil_xmas_adventure
{
    class SwitchBoard
    {
     
       public void TwoPaths() //TwoPaths Switch
       {
            Obstacles obstacles = new Obstacles();
            
            Console.WriteLine("\nAs you look down the Winter forrest walkway. \nHidden in the middle of the thick trees and snow. You notice two paths that you can choose from");
            Console.WriteLine("\nDo you take the path to the right? \nOr The Path to the left? \nMaybe you wanna turnback and end your adventuring days right there?");
            Console.WriteLine("\nLeft? \nRight? \nTurnback?");
            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "left":
                    Console.WriteLine("\nA True Hero always Turn Right first \n but then again who ever said you are a Hero... \n you take the left path");
                    obstacles.AnObstacle();
                    break;

                case "right":
                    Console.WriteLine("\nYou take the right path \nYou walk proudly for a few minutes when suddently.");
                    obstacles.AnObstacle();
                    break;

                case "turnback":
                    Console.WriteLine("\nYou Decide that this is enough adventuring in this forsaken winter cold for today. \nSo you turn back and End the game");
                    Environment.Exit(0);
                    break;
                    
                default:
                    Console.WriteLine("I'm sorry, I didn't understand that!");
                    TwoPaths();
                    break;
            }           
       }
    }
}
