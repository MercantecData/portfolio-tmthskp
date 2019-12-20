using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class BattleSwitchBoard
    {
        
        /***************** Attack Switc ********************/
        public void MonsterAttackSwitch(EnemyEncounters enemyEncounters)
        { 
            BattleEngine battleEngine = new BattleEngine();  
            
            Console.WriteLine("The Monster Looks at you with a mean gaze");
            Console.WriteLine("monster got hp: " + enemyEncounters.MonsterHP);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nAttack? \nRunaway");
            Console.ForegroundColor = ConsoleColor.Gray;

            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "attack":
                case "atk":
                case "attk":
                case "atck":
                case "a":
                    Console.WriteLine("\nYou attack");
                    battleEngine.BattleEngine_Monster(enemyEncounters);
                    break;

                case "runaway":
                case "run":
                case "r":
                    Console.WriteLine("You Run away");
                    Console.WriteLine("But You wont get far");
                    Console.WriteLine("");
                    SwitchBoard switchBoard = new SwitchBoard();
                    switchBoard.TwoPaths();
                    break;

                default:
                    Console.WriteLine("Sorry didn't understand that");
                    MonsterAttackSwitch(enemyEncounters);
                    break;
            }
        }

    }
}
