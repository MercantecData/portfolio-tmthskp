using System;


namespace opg_evil_xmas_adventure
{
    class BattleEngine
    {
          
        /****** Battle Engine der skal styrer alle fights ******/
        public void BattleEngine_Monster(EnemyEncounters enemyEncounters, Player player, Reward reward, Obstacles obstacles, SwitchBoard switchBoard, MonsterObstacle monsterObstacle, BattleSwitchBoard battleSwitchBoard, BattleEngine battleEngine, SoundFx soundFx)//Parametere til at føre data vidre
        {
           
            bool IsrunningPlayer = true;
           
                while (IsrunningPlayer)
                {
                    bool IsrunningMonster = true;
                    Console.WriteLine("monster got hp: " + enemyEncounters.MonsterHP);
                    soundFx.AttackSound();
                    Console.Write("You do " + player.PlayerDMG + " amount of dmg");
                    Console.WriteLine();

                    if (enemyEncounters.MonsterHP < player.PlayerDMG) // Lower than varibel 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nThe Monster lies Bleeding violently at your feet ");
                        soundFx.EnemyKillSound();
                        reward.GoldLoot(player, switchBoard, obstacles, monsterObstacle, reward, battleSwitchBoard, enemyEncounters, battleEngine, soundFx);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        IsrunningPlayer = false;
                    }

                    if (enemyEncounters.MonsterHP == player.PlayerDMG) // Equal varibel 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\nThe Monster dies ");
                        soundFx.EnemyKillSound();
                        reward.GoldLoot(player, switchBoard, obstacles, monsterObstacle, reward, battleSwitchBoard, enemyEncounters, battleEngine, soundFx);
                        Console.ForegroundColor = ConsoleColor.Gray;                       
                        IsrunningPlayer = false;
                    }

                    else if (enemyEncounters.MonsterHP > player.PlayerDMG) // higher than varibel
                    {
                        enemyEncounters.MonsterHP -= player.PlayerDMG;                        
                        Console.WriteLine("Monster has " + enemyEncounters.MonsterHP + " Hp left");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("You didnt kill it. \nMonster fights back");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Gray;

                        //Monster Fights Back
                        while (IsrunningMonster)
                        {
                            soundFx.EnemyAttackSound();
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
                                player.PlayerHP -= enemyEncounters.MonsterDMG;
                                
                                Console.WriteLine("You have " + player.PlayerHP + " Hp left");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("It didnt kill you. \nFight back");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ReadLine();                                
                                IsrunningMonster = false;
                                
                            }
                        }
                    }
                }
           
        }
    }
}
