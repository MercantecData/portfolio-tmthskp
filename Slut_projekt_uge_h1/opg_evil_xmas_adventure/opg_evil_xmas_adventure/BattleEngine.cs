using System;


namespace opg_evil_xmas_adventure
{
    class BattleEngine
    {

        /****** Battle Engine der skal styrer alle fights ******/
        public void BattleEngine_Monster(EnemyEncounters enemyEncounters)
        {
            Player player = new Player();
            Reward reward = new Reward();

            player.PlayerStats();

            bool IsrunningPlayer = true;
            while (IsrunningPlayer)
            {
                while (IsrunningPlayer)
                {
                    bool IsrunningMonster = true;
                    Console.WriteLine("monster got hp: " + enemyEncounters.MonsterHP);
                    Console.Write("You do " + player.PlayerDMG + " amount of dmg");
                    Console.WriteLine();

                    if (enemyEncounters.MonsterHP < player.PlayerDMG) // Lower than varibel 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nThe Monster lies Bleeding violently at your feet ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        reward.GoldLoot(player);                     
                        IsrunningPlayer = false;
                    }

                    if (enemyEncounters.MonsterHP == player.PlayerDMG) // Equal varibel 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nThe Monster dies ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        reward.GoldLoot(player);                       
                        IsrunningPlayer = false;
                    }

                    else if (enemyEncounters.MonsterHP > player.PlayerDMG) // higher than varibel
                    {
                        enemyEncounters.MonsterHP = (enemyEncounters.MonsterHP - player.PlayerDMG);

                        Console.WriteLine("Monster has " + enemyEncounters.MonsterHP + " Hp left");
                        Console.WriteLine("\nYou didnt kill it. \nMonster fights back");
                        Console.ReadLine();

                        //Monster Fights Back
                        while (IsrunningMonster)
                        {
                            Console.Write("Monster do " + enemyEncounters.MonsterDMG + " amount of dmg");
                            Console.WriteLine();

                            if (player.PlayerHP < enemyEncounters.MonsterDMG) // Lower than varibel 
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at its feet ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Environment.Exit(0);// lukker console
                            }

                            else if (player.PlayerHP == enemyEncounters.MonsterDMG) // Equal varibel 
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou are Defeated ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Environment.Exit(0);
                            }

                            else if (player.PlayerHP > enemyEncounters.MonsterDMG)
                            {
                                player.PlayerHP = (player.PlayerHP - enemyEncounters.MonsterDMG);
                                
                                Console.WriteLine("You have " + player.PlayerHP + " Hp left");
                                Console.WriteLine("\nIt didnt kill you. \nFight back");
                                Console.ReadLine();
                                IsrunningMonster = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
