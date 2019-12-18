using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class BattleSwitchBoard
    {
        
        //EnemyEncounters enemyEncounters = new EnemyEncounters();
        //MonsterObstacle monsterObstacle = new MonsterObstacle();

        /***************** Attack Switches ********************/
        public void MonsterAttackSwitch(EnemyEncounters enemyEncounters)
        { 
            BattleEngine battleEngine = new BattleEngine();  
            
            Console.WriteLine("The Monster Looks at you with a mean gaze");
            Console.WriteLine("monster got hp: " + enemyEncounters.MonsterHP);
            Console.WriteLine("\nAttack? \nRunaway");

            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "attack":
                case "atk":
                    Console.WriteLine("\nYou attack");
                    battleEngine.BattleEngine_Monster(enemyEncounters);
                    break;

                case "runaway":
                case "run":
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
