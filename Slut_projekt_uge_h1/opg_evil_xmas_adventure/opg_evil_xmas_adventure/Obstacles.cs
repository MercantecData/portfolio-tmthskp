using System;


namespace opg_evil_xmas_adventure
{
    class Obstacles
    {
            
       /****** Encounter randomizer hvad møder playeren næste ******/
        public void AnObstacle(MonsterObstacle monsterObstacle, SwitchBoard switchBoard, Obstacles obstacles, Player player, Reward reward, BattleSwitchBoard battleSwitchBoard, EnemyEncounters enemyEncounters, BattleEngine battleEngine, SoundFx soundFx)
        {
            
            Npc npc = new Npc();

            Random random = new Random();

            int randomNumber = random.Next(1, 5);
            
            if (randomNumber == 1)
            {
                soundFx.EncounterSound();
                monsterObstacle.MonsterEncounter(enemyEncounters, battleEngine, player, reward, obstacles, battleSwitchBoard, switchBoard, monsterObstacle, soundFx);           
            }
           
            else if (randomNumber == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Nothing happens... \nBut you do feel a nice cool breeze \ncoming from down the road");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
            else if (randomNumber == 3)
            {
                npc.NpcEncounter(monsterObstacle, switchBoard, obstacles, player, reward, battleSwitchBoard, enemyEncounters, battleEngine, soundFx);
            }

            else if (randomNumber == 4)
            {
                Console.WriteLine("You meet a wandering Merchant");
            }
        }        
    }
}
