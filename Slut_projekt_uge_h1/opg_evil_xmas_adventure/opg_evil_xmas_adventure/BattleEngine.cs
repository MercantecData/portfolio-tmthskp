using System;


namespace opg_evil_xmas_adventure
{
    class BattleEngine
    {
        

        public void BattleEngine_Monster(EnemyEncounters enemyEncounters)
        {
            PlayerStats playerStats = new PlayerStats();

            bool IsrunningPlayer = true;
            while (IsrunningPlayer)
            {
                while (IsrunningPlayer)
                {
                    bool IsrunningMonster = true;
                    Console.WriteLine("monster got hp: " + enemyEncounters.MonsterHP);
                    Console.Write("You do " + playerStats.PlayerDMG + " amount of dmg");
                    Console.WriteLine();

                    if (enemyEncounters.MonsterHP < playerStats.PlayerDMG) // Lower than varibel 
                    {
                        
                        Console.WriteLine("\nThe Monster lies Bleeding violently at your feet ");
                        IsrunningPlayer = false;
                    }

                    if (enemyEncounters.MonsterHP == playerStats.PlayerDMG) // Equal varibel 
                    {
                       
                        Console.WriteLine("\nThe Monster dies ");
                        IsrunningPlayer = false;
                    }

                    else if (enemyEncounters.MonsterHP > playerStats.PlayerDMG) // higher than varibel
                    {
                        enemyEncounters.MonsterHP = (enemyEncounters.MonsterHP - playerStats.PlayerDMG);

                        Console.WriteLine("Monster has " + enemyEncounters.MonsterHP + " Hp left");
                        Console.WriteLine("\nYou didnt kill it. \nMonster fights back");
                        Console.ReadLine();

                        //Goblin Fights Back
                        while (IsrunningMonster)
                        {
                            Console.Write("Monster do " + enemyEncounters.MonsterDMG + " amount of dmg");
                            Console.WriteLine();

                            if (playerStats.PlayerHP < enemyEncounters.MonsterDMG) // Lower than varibel 
                            {
                                Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at its feet ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP == enemyEncounters.MonsterDMG) // Equal varibel 
                            {
                                Console.WriteLine("\nYou are Defeated ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP > enemyEncounters.MonsterDMG)
                            {
                                playerStats.PlayerHP = (playerStats.PlayerHP - enemyEncounters.MonsterDMG);
                                
                                Console.WriteLine("You have " + playerStats.PlayerHP + " Hp left");
                                Console.WriteLine("\nIt didnt kill you. \nFight back");
                                Console.ReadLine();
                                IsrunningMonster = false;
                            }
                        }
                    }
                }
            }
        }

        /*
        public void BattleEngine_Reindeer() 
        {
            bool IsrunningPlayer = true;
            while (IsrunningPlayer)
            {
                while (IsrunningPlayer)
                {
                    bool IsrunningMonster = true;
                    Console.Write("You do " + playerStats.PlayerDMG + " amount of dmg");
                    Console.WriteLine();

                    if (enemyEncounters.AdultReindeerHP < playerStats.PlayerDMG) // Lower than varibel 
                    {
                        //EnemyKillSound();
                        Console.WriteLine("\nThe Monster lies Bleeding violently at your feet ");
                        IsrunningPlayer = false;
                    }

                    if (enemyEncounters.AdultReindeerHP == playerStats.PlayerDMG) // Equal varibel 
                    {
                        //EnemyKillSound();
                        Console.WriteLine("\nThe Monster dies ");
                        IsrunningPlayer = false;
                    }

                    else if (enemyEncounters.AdultReindeerHP > playerStats.PlayerDMG) // higher than varibel
                    {
                        enemyEncounters.AdultReindeerHP = (enemyEncounters.AdultReindeerHP - playerStats.PlayerDMG);

                        Console.WriteLine("Monster has " + enemyEncounters.AdultReindeerHP + " Hp left");
                        Console.WriteLine("\nYou didnt kill it. \nMonster fights back");
                        Console.ReadLine();

                        //Goblin Fights Back
                        while (IsrunningMonster)
                        {
                            Console.Write("Monster do " + enemyEncounters.AdultReindeerDMG + " amount of dmg");
                            Console.WriteLine();

                            if (playerStats.PlayerHP < enemyEncounters.AdultReindeerDMG) // Lower than varibel 
                            {
                                Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at its feet ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP == enemyEncounters.AdultReindeerDMG) // Equal varibel 
                            {
                                Console.WriteLine("\nYou are Defeated ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP > enemyEncounters.AdultReindeerDMG)
                            {
                                playerStats.PlayerHP = (playerStats.PlayerHP - enemyEncounters.AdultReindeerDMG);
                                //AttackSound();
                                Console.WriteLine("You have " + playerStats.PlayerHP + " Hp left");
                                Console.WriteLine("\nIt didnt kill you. \nFight back");
                                Console.ReadLine();
                                IsrunningMonster = false;
                            }
                        }
                    }
                }
            }           
        }
        
        public void BattleEngine_XmasGnome()
        {
            bool IsrunningPlayer = true;
            while (IsrunningPlayer)
            {
                while (IsrunningPlayer)
                {
                    bool IsrunningMonster = true;
                    Console.Write("You do " + playerStats.PlayerDMG + " amount of dmg");
                    Console.WriteLine();

                    if (enemyEncounters.XmasGnomeHP < playerStats.PlayerDMG) // Lower than varibel 
                    {
                        //EnemyKillSound();
                        Console.WriteLine("\nThe Monster lies Bleeding violently at your feet ");
                        IsrunningPlayer = false;
                    }

                    if (enemyEncounters.XmasGnomeHP == playerStats.PlayerDMG) // Equal varibel 
                    {
                        //EnemyKillSound();
                        Console.WriteLine("\nThe Monster dies ");
                        IsrunningPlayer = false;
                    }

                    else if (enemyEncounters.XmasGnomeHP > playerStats.PlayerDMG) // higher than varibel
                    {
                        enemyEncounters.XmasGnomeHP = (enemyEncounters.XmasGnomeHP - playerStats.PlayerDMG);

                        Console.WriteLine("Monster has " + enemyEncounters.XmasGnomeHP + " Hp left");
                        Console.WriteLine("\nYou didnt kill it. \nMonster fights back");
                        Console.ReadLine();

                        //Goblin Fights Back
                        while (IsrunningMonster)
                        {
                            Console.Write("Monster do " + enemyEncounters.XmasGnomeDMG + " amount of dmg");
                            Console.WriteLine();

                            if (playerStats.PlayerHP < enemyEncounters.XmasGnomeDMG) // Lower than varibel 
                            {
                                Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at its feet ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP == enemyEncounters.XmasGnomeDMG) // Equal varibel 
                            {
                                Console.WriteLine("\nYou are Defeated ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP > enemyEncounters.XmasGnomeDMG)
                            {
                                playerStats.PlayerHP = (playerStats.PlayerHP - enemyEncounters.XmasGnomeDMG);
                                //AttackSound();
                                Console.WriteLine("You have " + playerStats.PlayerHP + " Hp left");
                                Console.WriteLine("\nIt didnt kill you. \nFight back");
                                Console.ReadLine();
                                IsrunningMonster = false;
                            }
                        }
                    }
                }
            }
        }

        public void BattleEngine_XmasElf()
        {
            bool IsrunningPlayer = true;
            while (IsrunningPlayer)
            {
                while (IsrunningPlayer)
                {
                    bool IsrunningMonster = true;
                    Console.Write("You do " + playerStats.PlayerDMG + " amount of dmg");
                    Console.WriteLine();

                    if (enemyEncounters.XmasElfHP < playerStats.PlayerDMG) // Lower than varibel 
                    {
                        //EnemyKillSound();
                        Console.WriteLine("\nThe Monster lies Bleeding violently at your feet ");
                        IsrunningPlayer = false;
                    }

                    if (enemyEncounters.XmasElfHP == playerStats.PlayerDMG) // Equal varibel 
                    {
                        //EnemyKillSound();
                        Console.WriteLine("\nThe Monster dies ");
                        IsrunningPlayer = false;
                    }

                    else if (enemyEncounters.XmasElfHP > playerStats.PlayerDMG) // higher than varibel
                    {
                        enemyEncounters.XmasElfHP = (enemyEncounters.XmasElfHP - playerStats.PlayerDMG);

                        Console.WriteLine("Monster has " + enemyEncounters.XmasElfHP + " Hp left");
                        Console.WriteLine("\nYou didnt kill it. \nMonster fights back");
                        Console.ReadLine();

                        //Goblin Fights Back
                        while (IsrunningMonster)
                        {
                            Console.Write("Monster do " + enemyEncounters.XmasElfDMG + " amount of dmg");
                            Console.WriteLine();

                            if (playerStats.PlayerHP < enemyEncounters.XmasElfDMG) // Lower than varibel 
                            {
                                Console.WriteLine("\nYou are Defeated \nand lie Bleeding violently at its feet ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP == enemyEncounters.XmasElfDMG) // Equal varibel 
                            {
                                Console.WriteLine("\nYou are Defeated ");
                                IsrunningPlayer = false;
                                IsrunningMonster = false;
                            }

                            else if (playerStats.PlayerHP > enemyEncounters.XmasElfDMG)
                            {
                                playerStats.PlayerHP = (playerStats.PlayerHP - enemyEncounters.XmasElfDMG);
                                //AttackSound();
                                Console.WriteLine("You have " + playerStats.PlayerHP + " Hp left");
                                Console.WriteLine("\nIt didnt kill you. \nFight back");
                                Console.ReadLine();
                                IsrunningMonster = false;
                            }
                        }
                    }
                }
            }
        }
        */





    }
}
