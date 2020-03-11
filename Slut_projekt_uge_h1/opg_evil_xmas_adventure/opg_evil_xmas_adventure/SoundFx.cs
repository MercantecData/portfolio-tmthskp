using System;
using System.Collections.Generic;
using System.Text;

namespace opg_evil_xmas_adventure
{
    class SoundFx
    {
        /*  -------------------------- Sounds Functions ------------------------------- */

        //IntroSong Beeps
        public void IntroMusic()
        {
            Console.Beep(440, 225); 
            Console.Beep(622, 125);
            Console.Beep(622, 225); 
            Console.Beep(659, 125);
            Console.Beep(415, 225); 
            Console.Beep(440, 400);
            Console.Beep(523, 225); 
            Console.Beep(784, 125);
            Console.Beep(698, 125); 
            Console.Beep(622, 125);
            Console.Beep(659, 125); 
            Console.Beep(415, 350);
            Console.Beep(523, 100); 
            Console.Beep(740, 125);
            Console.Beep(415, 125); 
            Console.Beep(440, 125);
            Console.Beep(523, 225); 
            Console.Beep(784, 125);
            Console.Beep(440, 225); 
            Console.Beep(622, 300);
        }

        //AttackSound Beeps
        public void AttackSound()
        {
            Console.Beep(400, 350);
            Console.Beep(600, 350);

        }

        public void EnemyAttackSound()
        {
            Console.Beep(200, 350);
            Console.Beep(300, 350);

        }

        //RunAwaySound beeps
        public void RunAwaySound()
        {
            Console.Beep(400, 200);
            Console.Beep(250, 250);
            Console.Beep(400, 300);
            Console.Beep(200, 500);

        }

        //EnemyKillSound Beeps
        public void EnemyKillSound()
        {
            Console.Beep(400, 350);
            Console.Beep(600, 300);
            Console.Beep(650, 300);
            Console.Beep(750, 250);

        }

        //LootSound Beeps
        public void LootSound()
        {
            Console.Beep(500, 300);
            Console.Beep(800, 300);
            Console.Beep(750, 250);
            Console.Beep(750, 250);
            Console.Beep(800, 200);

        }

        //Enemy enciunter beeps
        public void EncounterSound()
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

