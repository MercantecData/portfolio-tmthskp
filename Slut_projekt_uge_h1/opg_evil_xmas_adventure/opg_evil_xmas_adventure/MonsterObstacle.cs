using System;


namespace opg_evil_xmas_adventure
{
    class MonsterObstacle
    {
        BattleSwitchBoard battleSwitchBoard = new BattleSwitchBoard();
        EnemyEncounters enemyEncounters = new EnemyEncounters();
        
        public void MonsterEncounter() //Array randomizer of Monster list
        {
            bool isrunning = true;

            Random RandomMonster = new Random(); //Randomizer
            string[] MonsterList = { "AdultReindeer ", "XmasGnome ", "XmasElf " }; //Monster Array list

            while (isrunning)
            {
                int i = RandomMonster.Next(0, 3);
                string Youmeet = MonsterList[i];

                if (Youmeet == "AdultReindeer ")
                {
                    Console.WriteLine("\nYou Encounter an Adult Reindeer");
                    enemyEncounters.AdultReindeer();
                    Console.WriteLine("HP: " + enemyEncounters.MonsterHP);
                    Console.WriteLine("DMG: " + enemyEncounters.MonsterDMG);
                    battleSwitchBoard.MonsterAttackSwitch(enemyEncounters);
                    //battleSwitchBoard.ReindeerAttackSwitch();
                }
                
                else if (Youmeet == "XmasGnome ")
                {
                    Console.WriteLine("\nYou encounter a Xmas Gnome");
                    enemyEncounters.XmasGnome();
                    Console.WriteLine("HP: " + enemyEncounters.MonsterHP);
                    Console.WriteLine("DMG: " + enemyEncounters.MonsterDMG);
                    battleSwitchBoard.MonsterAttackSwitch(enemyEncounters);
                    //battleSwitchBoard.XmasGnomeAttackSwitch();
                }

                else if (Youmeet == "XmasElf ")
                {
                    enemyEncounters.AdultReindeer();
                    Console.WriteLine("\nYou encounter a Xmas Elf");
                    enemyEncounters.XmasGnome();
                    Console.WriteLine("HP: " + enemyEncounters.MonsterHP);
                    Console.WriteLine("DMG: " + enemyEncounters.MonsterDMG);
                    battleSwitchBoard.MonsterAttackSwitch(enemyEncounters);
                    //battleSwitchBoard.XmasElfAttackSwitch();
                }
                
                else
                {
                    isrunning = false;
                }
                Console.ReadLine();
            }
        }
    }
}
