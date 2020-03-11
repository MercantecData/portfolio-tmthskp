using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace opg_evil_xmas_adventure
{
    class Reward
    {
        // -------- Gold Loot Program Randomizer arrays ----------
        public void GoldLoot(Player player, SwitchBoard switchBoard, Obstacles obstacles, MonsterObstacle monsterObstacle, Reward reward, BattleSwitchBoard battleSwitchBoard, EnemyEncounters enemyEncounters, BattleEngine battleEngine, SoundFx soundFx)
        {
            Random Randomizer = new Random();

            int[] GoldPieces = { 3, 6, 9, 12, 15, 18, 21 };
            //player.PlayerStats();
            int GoldIndex = Randomizer.Next(0, GoldPieces.Length); // randomly  picks a number between chosen range Array
            Console.Write("You Get " + GoldPieces[GoldIndex] + " Gold pieces as reward ");
            Thread.Sleep(500);
            soundFx.LootSound();
            player.PlayerGold += GoldPieces[GoldIndex];
            
            Console.WriteLine("Your Current Gold is now: " + player.PlayerGold);
            Console.ForegroundColor = ConsoleColor.Gray;
            switchBoard.TwoPaths(monsterObstacle, switchBoard, obstacles, player, reward,battleSwitchBoard, enemyEncounters, battleEngine, soundFx);

        }
    }
}
