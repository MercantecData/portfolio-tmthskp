using System;


namespace opg_evil_xmas_adventure
{
    class SwitchBoard
    {
        
        /****** TwoPaths Switch ******/
       public void TwoPaths()
       {
            Obstacles obstacles = new Obstacles();
            Player player = new Player();

            Console.WriteLine("\nAs you look down the Winter forrest walkway. \nHidden in the middle of the thick trees and snow. You notice two paths that you can choose from");
            Console.WriteLine("\nDo you take the path to the right? \nOr The Path to the left? \nCheck your stats \nMaybe you wanna turnback and end your adventuring days right there?");
            Console.WriteLine("\nMake your Choice: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Left? \nRight? \nView your stats(stats) \nTurnback?");
            Console.ForegroundColor = ConsoleColor.Gray;
            string userResponse = Console.ReadLine();
            
            switch (userResponse.ToLower())
            {
                case "left":
                case "l":
                    Console.WriteLine("\nA True Hero always Turn Right first \nbut then again who ever said you are a Hero... \nyou take the left path");
                    obstacles.AnObstacle();
                    break;

                case "right":
                case "r":
                    Console.WriteLine("\nYou take the right path \nYou walk proudly for a few minutes when suddently.");
                    obstacles.AnObstacle();
                    break;

                case "view stats":
                case "stats":
                case "s":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    player.PlayerStats();
                    Console.WriteLine("Current Stats");
                    Console.WriteLine("Your Hp amount is: " + player.PlayerHP);
                    Console.WriteLine("Your DMG capability is: " + player.PlayerDMG + "(base 1D6*2)");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                case "turnback":
                case "back":
                case "b":
                case "t":
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
