using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class BattleSwitchBoard
    {
        BattleEngine battleEngine = new BattleEngine();


        /***************** Attack Switches ********************/
        public void MonsterAttackSwitch()
        {
            Console.WriteLine("The Monster Looks at you with a mean gaze");
            Console.WriteLine("\nAttack? \nRunaway");

            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "attack":
                case "atk":
                    Console.WriteLine("\nYou attack");
                    battleEngine.BattleEngine_Monster();
                    break;

                case "runaway":
                case "run":
                    //RunAwaySound();
                    Console.WriteLine("You Run away");
                    Console.WriteLine("But You wont get far");
                    Console.WriteLine("");
                    SwitchBoard switchBoard = new SwitchBoard();
                    switchBoard.TwoPaths();
                    break;

                default:
                    Console.WriteLine("Sorry didn't understand that");
                    MonsterAttackSwitch();
                    break;
            }
        }


        /*
        public void ReindeerAttackSwitch()
        {   
            Console.WriteLine("The Adult Reindeer Looks at you with a mean gaze");
            Console.WriteLine("\nAttack? \nRunaway");

            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "attack":
                case "atk":
                    Console.WriteLine("\nYou attack");
                    battleEngine.BattleEngine_Reindeer();
                    break;

                case "runaway":
                case "run":
                    //RunAwaySound();
                    Console.WriteLine("You Run away");
                    Console.WriteLine("But You wont get far");
                    Console.WriteLine("");
                    SwitchBoard switchBoard = new SwitchBoard();
                    switchBoard.TwoPaths();
                    break;

                default:
                    Console.WriteLine("Sorry didn't understand that");
                    ReindeerAttackSwitch();
                    break;
            }
        }

         
         public void XmasGnomeAttackSwitch()
         {
             Console.WriteLine("\nAttack? \nRunaway");

             string userResponse = Console.ReadLine();
             switch (userResponse.ToLower())
             {
                 case "attack":
                 case "atk":
                     Console.WriteLine("\nYou attack");
                     battleEngine.BattleEngine_XmasGnome();
                     break;

                 case "runaway":
                 case "run":
                     //RunAwaySound();
                     Console.WriteLine("You Run away");
                     Console.WriteLine("But You wont get far");
                     Console.WriteLine("");
                    SwitchBoard switchBoard = new SwitchBoard();
                    switchBoard.TwoPaths();
                    break;

                 default:
                     Console.WriteLine("Sorry didn't understand that");
                     //XmasGnomeAttackSwitch();
                     break;
             }
         }

         public void XmasElfAttackSwitch()
         {
             Console.WriteLine("\nAttack? \nRunaway");

             string userResponse = Console.ReadLine();
             switch (userResponse.ToLower())
             {
                 case "attack":
                 case "atk":
                     Console.WriteLine("\nYou attack");
                     battleEngine.BattleEngine_XmasElf();
                     break;

                 case "runaway":
                 case "run":
                     //RunAwaySound();
                     Console.WriteLine("You Run away");
                     Console.WriteLine("But You wont get far");
                     Console.WriteLine("");
                    SwitchBoard switchBoard = new SwitchBoard();
                    switchBoard.TwoPaths();
                    break;

                 default:
                     Console.WriteLine("Sorry didn't understand that");
                    // XmasElfAttackSwitch();
                     break;
             }
         }
         */



    }
}
