using System;


namespace opg_evil_xmas_adventure
{
    class MonsterObstacle
    {
        BattleSwitchBoard battleSwitchBoard = new BattleSwitchBoard();

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
                    battleSwitchBoard.MonsterAttackSwitch();
                    //battleSwitchBoard.ReindeerAttackSwitch();
                }
                
                else if (Youmeet == "XmasGnome ")
                {
                    Console.WriteLine("\nYou encounter a Xmas Gnome");
                    battleSwitchBoard.MonsterAttackSwitch();
                    //battleSwitchBoard.XmasGnomeAttackSwitch();
                }

                else if (Youmeet == "XmasElf ")
                {
                    Console.WriteLine("\nYou encounter a Xmas Elf");
                    battleSwitchBoard.MonsterAttackSwitch();
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
