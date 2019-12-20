using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class Npc
    {
        /****** Npc encounters for dialogue muligheder ******/
       public void NpcEncounter() 
       {
            SwitchBoard switchBoard = new SwitchBoard();
            Player player = new Player();
            Random random = new Random();
            
            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n'Hello' the person said");
                    Console.WriteLine("Be wary on the Road here adventurer. \nSeveral nasty looking Xmas creatures are seen roaming around");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    dialogueOptions1();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n'Hi' the person said");
                    Console.WriteLine("Take care on the road friend. \nThe Road is slippery in this weather \nand Santas little helpers are messing around");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    dialogueOptions2();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n'Sup' the person said");
                    Console.WriteLine("Carefull not to slip in the corpse of that gnome back there as i did");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    dialogueOptions3();
                    break;

                case 4://Healer som jule gave selvfølgelig med 24 som amount heal i forhold til tema
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nMerry Xmas!");
                    Console.WriteLine("Here have a present from me to you in these Xmas times");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HP has been restored and boosted. You gained 24 HP!");
                    player.PlayerHP += 24;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    switchBoard.TwoPaths();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nIdk what the fuck just happened");
                    Console.WriteLine("He says with a very confused look on his face");
                    Console.WriteLine("He doesn't seem to notice you as he walks past you...");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    switchBoard.TwoPaths();
                    break;
            }
       }

        /*****************Dialogue Options******************/
        public void dialogueOptions1()
        {
            SwitchBoard switchBoard = new SwitchBoard();
            Console.WriteLine("\nWhat do you say? ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Thank you friend \n2. Mind your own business");
            Console.ForegroundColor = ConsoleColor.Gray;
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("He Smiles politely at your response \nand move on with his journey");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                    
                case "2":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("He grunts at your response. \nClearly dissatisfied with your attitude");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
               
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You do nothing and continue onwards");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }           
            switchBoard.TwoPaths();
        }

        public void dialogueOptions2()
        {
            SwitchBoard switchBoard = new SwitchBoard();
            Console.WriteLine("\nWhat do you say? ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Thank you for the warning Friend... \n2. Hmph I dont need care im invinsible");
            Console.ForegroundColor = ConsoleColor.Gray;
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("He Smiles politely \nalways nice to help a fellow traveler");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                
                case "2":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("He smirk at your response. \nShaking his head as he walks away");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You do nothing and continue onwards");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            switchBoard.TwoPaths();
        }

        public void dialogueOptions3()
        {
            SwitchBoard switchBoard = new SwitchBoard();
            Console.WriteLine("\nWhat do you say?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Thank you. Hope you are okay \n2. HA HA HA you Fool");
            Console.ForegroundColor = ConsoleColor.Gray;
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("'who me? yeah just wanted to give \nyou a headsup thats all' \nHe says as he walks on");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                
                case "2":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("He clench his fist at you for a second. \nBut realize you are not worth the effort ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("You do nothing and continue onwards");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            switchBoard.TwoPaths();
        }


    }
}
