using System;


namespace opg_evil_xmas_adventure
{
    class PlayerStats
    {
        static Random random = new Random(); //number randomizer

        public int PlayerHP = 30;
        public int PlayerDMG = random.Next(1, 6)*2;

       
    }
}
