using System;


namespace opg_evil_xmas_adventure
{
    class MonsterObstacle
    {
        
        /****** Array randomizer af Monster liste ******/
        public void MonsterEncounter(EnemyEncounters enemyEncounters, BattleEngine battleEngine, Player player, Reward reward, Obstacles obstacles, BattleSwitchBoard battleSwitchBoard, SwitchBoard switchBoard, MonsterObstacle monsterObstacle, SoundFx soundFx) 
        {
            
            var RandomMonster = new Random(); //Randomizer

            bool isrunning = true;
           
            string[] MonsterList = { "AdultReindeer ", "XmasGnome ", "XmasElf " }; //Monster Array list

            while (isrunning)
            {
                int i = RandomMonster.Next(0, 3);
                string Youmeet = MonsterList[i];

                if (Youmeet == "AdultReindeer ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nYou Encounter an Adult Reindeer");
                    enemyEncounters.AdultReindeer();
                    Console.WriteLine("HP: " + enemyEncounters.MonsterHP);
                    Console.WriteLine("DMG Value: " + enemyEncounters.MonsterDMG);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    battleSwitchBoard.MonsterAttackSwitch(enemyEncounters, battleEngine, player, reward, obstacles, monsterObstacle, switchBoard, battleSwitchBoard, soundFx);
                }
                
                else if (Youmeet == "XmasGnome ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nYou encounter a Xmas Gnome");
                    enemyEncounters.XmasGnome();
                    Console.WriteLine("HP: " + enemyEncounters.MonsterHP);
                    Console.WriteLine("DMG Value: " + enemyEncounters.MonsterDMG);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    battleSwitchBoard.MonsterAttackSwitch(enemyEncounters, battleEngine, player, reward, obstacles, monsterObstacle, switchBoard, battleSwitchBoard, soundFx);
                }

                else if (Youmeet == "XmasElf ")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    enemyEncounters.AdultReindeer();
                    Console.WriteLine("\nYou encounter a Xmas Elf");
                    enemyEncounters.XmasGnome();
                    Console.WriteLine("HP: " + enemyEncounters.MonsterHP);
                    Console.WriteLine("DMG Value: " + enemyEncounters.MonsterDMG);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    battleSwitchBoard.MonsterAttackSwitch(enemyEncounters, battleEngine, player, reward, obstacles, monsterObstacle, switchBoard, battleSwitchBoard, soundFx);
                }
                
                else
                {
                    isrunning = false;
                }
                Console.ReadLine();
                switchBoard.TwoPaths(monsterObstacle, switchBoard, obstacles, player, reward, battleSwitchBoard, enemyEncounters, battleEngine, soundFx);
            }
        }
    }
}
