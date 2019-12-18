using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class Npc
    {
       public void NpcEncounter() 
       {
            Player player = new Player();

            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("\n'Hello' the person said");
                    Console.WriteLine("Be wary on the Road here adventurer. \nSeveral nasty looking Xmas creatures are seen roaming around");
                    dialogueOptions1();
                    break;

                case 2:
                    Console.WriteLine("\n'Hi' the person said");
                    Console.WriteLine("Take care on the road friend. \nThe Road is slippery in this weather \nand Santas little helpers are messing around");
                    dialogueOptions2();
                    break;

                case 3:
                    Console.WriteLine("\n'Sup' the person said");
                    Console.WriteLine("Carefull not to slip in the corpse of that gnome back there as i did");
                    dialogueOptions3();
                    break;

                case 4:
                    Console.WriteLine("\nMerry Xmas!");
                    Console.WriteLine("Here have a present from me to you in this Xmas time");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HP has been restored and boosted. You gained 100 HP!");
                    player.PlayerHP += 100;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:
                    Console.WriteLine("\nIdk what the fuck just happened");
                    Console.WriteLine("He says with a very confused look on his face");
                    Console.WriteLine("He doesn't seem to notice you as he walks past you...");
                    break;
            }
       }

        /*****************Dialogue Options******************/
        static void dialogueOptions1()
        {
            SwitchBoard switchBoard = new SwitchBoard();
            Console.WriteLine("\nWhat do you say? \n1. Thank you friend \n2. Mind your own business");
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.WriteLine("He Smiles politely at your response \nand move on with his journey");
                    break;
                case "2":
                    Console.WriteLine("He grunts at your response. \nClearly dissatisfied with your attitude");
                    break;
                default:
                    Console.WriteLine("You do nothing and continue onwards");
                    break;
            }
            
            switchBoard.TwoPaths();
        }

        static void dialogueOptions2()
        {
            SwitchBoard switchBoard = new SwitchBoard();
            Console.WriteLine("\nWhat do you say? \n1. Thank you for the warning Friend... \n2. Hmph I dont need care im invinsible");
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.WriteLine("He Smiles politely \nalways nice to help a fellow traveler");
                    break;
                case "2":
                    Console.WriteLine("He smirk at your response. \nShaking his head as he walks away");
                    break;
                default:
                    Console.WriteLine("You do nothing and continue onwards");
                    break;
            }
            switchBoard.TwoPaths();
        }

        static void dialogueOptions3()
        {
            SwitchBoard switchBoard = new SwitchBoard();
            Console.WriteLine("\nWhat do you say? \n1. Thank you. Hope you are okay \n2. HA HA HA you Fool");
            string playerResponse = Console.ReadLine();
            switch (playerResponse.ToLower())
            {
                case "1":
                    Console.WriteLine("'who me? yeah just wanted to give \nyou a headsup thats all' \nHe says as he walks on");
                    break;
                case "2":
                    Console.WriteLine("He clench his fist at you for a second. \nBut realize you are not worth the effort ");
                    break;
                default:
                    Console.WriteLine("You do nothing and continue onwards");
                    break;
            }
            switchBoard.TwoPaths();
        }


    }
}
