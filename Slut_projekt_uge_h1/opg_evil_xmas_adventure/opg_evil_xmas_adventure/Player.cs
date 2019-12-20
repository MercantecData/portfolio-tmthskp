using System;


namespace opg_evil_xmas_adventure
{
    class Player
    {
        /***** Global Stats variabler ******/
        public int PlayerHP;
        public int PlayerDMG;
        public int PlayerGold;
        
        Random random = new Random(); //number randomizer
    
        public bool PlayerStats() 
        {
            PlayerHP = 24;
            PlayerDMG = random.Next(1, 6) * 2;
            PlayerGold = 12;
            return true;
        }
     
    }
}
