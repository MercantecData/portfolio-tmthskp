using System;


namespace opg_evil_xmas_adventure
{
    class Player
    {
        public int PlayerHP;
        public int PlayerDMG;
        
        Random random = new Random(); //number randomizer

        public bool PlayerStats() 
        { 
            PlayerHP = 30;
            PlayerDMG = random.Next(2, 6) * 2;
            return true;
        }
     
    }
}
