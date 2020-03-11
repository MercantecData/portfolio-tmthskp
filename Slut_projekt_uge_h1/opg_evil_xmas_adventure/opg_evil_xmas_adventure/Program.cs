using System;
using System.Threading;
using System.Collections.Generic;


namespace opg_evil_xmas_adventure
{
    class Program
    {

        /* -------------------------- Main Code ------------------------------- */
        static void Main(string[] args)
        
        {
            Player player = new Player();
            TextMethods textMethods = new TextMethods();
            SwitchBoard switchBoard = new SwitchBoard();
            Reward reward = new Reward();
            Obstacles obstacles = new Obstacles();
            BattleEngine battleEngine = new BattleEngine();
            BattleSwitchBoard battleSwitchBoard = new BattleSwitchBoard();
            MonsterObstacle monsterObstacle = new MonsterObstacle();
            EnemyEncounters enemyEncounters = new EnemyEncounters();
            SoundFx soundFx = new SoundFx();

            //GameTitle
            textMethods.GameTitle();
            //Game start song
            soundFx.IntroMusic();

            player.PlayerStats();

            Console.WriteLine("your stats are: ");
            Console.WriteLine("Health: " + player.PlayerHP);
            Console.WriteLine("Damage: " + player.PlayerDMG);
            Console.WriteLine("Your Gold is: " + player.PlayerGold);


            //StartGameText Method            
            Console.WriteLine(textMethods.StartGameText());
            Console.WriteLine("");

            bool gameloop = true;
            while(gameloop)
            { 
                //TwoPaths Function
                switchBoard.TwoPaths(monsterObstacle, switchBoard, obstacles, player,reward, battleSwitchBoard, enemyEncounters, battleEngine, soundFx);

                //Continue On Method
                Console.WriteLine(textMethods.ContinueOn());
            }
        }

    }
}
