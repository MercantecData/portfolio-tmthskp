using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class BattleSwitchBoard
    {
 
        /***************** Attack Switc ********************/
        public void MonsterAttackSwitch(EnemyEncounters enemyEncounters, BattleEngine battleEngine, Player player, Reward reward, Obstacles obstacles, MonsterObstacle monsterObstacle, SwitchBoard switchBoard, BattleSwitchBoard battleSwitchBoard, SoundFx soundFx)//Parametere til at føre data vidre
        {
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
                    battleEngine.BattleEngine_Monster(enemyEncounters, player, reward, obstacles, switchBoard, monsterObstacle, battleSwitchBoard, battleEngine, soundFx);
                    break;

                case "runaway":
                case "run":
                case "r":
                    Console.WriteLine("You Run away");
                    soundFx.RunAwaySound();
                    Console.WriteLine("But You wont get far");
                    Console.WriteLine("");
                    switchBoard.TwoPaths(monsterObstacle, switchBoard, obstacles, player, reward, battleSwitchBoard, enemyEncounters, battleEngine, soundFx);
                    break;

                default:
                    Console.WriteLine("Sorry didn't understand that");
                    MonsterAttackSwitch(enemyEncounters, battleEngine, player, reward, obstacles, monsterObstacle, switchBoard, battleSwitchBoard, soundFx);
                    break;
            }
        }
    }
}
