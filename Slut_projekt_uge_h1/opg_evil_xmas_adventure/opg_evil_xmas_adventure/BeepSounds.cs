using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class BeepSounds
    {
        /*  -------------------------- Sounds Functions ------------------------------- */

        //IntroSong Beeps
        static void IntroMusic()
        {
            Console.Beep(440, 125); Console.Beep(622, 125);
            Console.Beep(622, 125); Console.Beep(659, 125);
            Console.Beep(415, 125); Console.Beep(440, 300);
            Console.Beep(523, 125); Console.Beep(784, 125);
            Console.Beep(698, 125); Console.Beep(622, 125);
            Console.Beep(659, 125); Console.Beep(415, 250);
            Console.Beep(523, 125); Console.Beep(740, 125);
            Console.Beep(415, 125); Console.Beep(440, 125);
            Console.Beep(523, 125); Console.Beep(784, 125);
            Console.Beep(440, 125); Console.Beep(622, 200);
            Console.Beep(622, 125); Console.Beep(659, 125);
            Console.Beep(415, 125); Console.Beep(440, 210);
            Console.Beep(523, 125); Console.Beep(784, 125);

        }

        //AttackSound Beeps
        static void AttackSound()
        {
            Console.Beep(400, 350);
            Console.Beep(600, 350);

        }

        //RunAwaySound beeps
        static void RunAwaySound()
        {
            Console.Beep(400, 200);
            Console.Beep(250, 250);
            Console.Beep(400, 300);
            Console.Beep(200, 500);

        }

        //EnemyKillSound Beeps
        static void EnemyKillSound()
        {
            Console.Beep(400, 350);
            Console.Beep(600, 300);
            Console.Beep(650, 300);
            Console.Beep(750, 250);

        }

        //LootSound Beeps
        static void LootSound()
        {
            Console.Beep(500, 300);
            Console.Beep(800, 300);
            Console.Beep(750, 250);
            Console.Beep(750, 250);
            Console.Beep(800, 200);

        }

        static void EncounterSound()
        {
            Console.Beep(500, 400);
            Console.Beep(800, 300);
            Console.Beep(500, 400);
            Console.Beep(800, 300);
            Console.Beep(500, 300);
            Console.Beep(800, 200);

        }

    }
}
