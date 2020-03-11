using System;




namespace opg_evil_xmas_adventure
{
    class Player
    {

        /***** Global Stats variabler ******/        
        public int PlayerHP;
        public int PlayerDMG;
        public int PlayerGold;
    
       public void PlayerStats() 
        {
            PlayerHP = 25;
            PlayerDMG = 4;
            PlayerGold = 12;        
            /*Console.WriteLine(PlayerHP);
            Console.WriteLine(PlayerDMG);
            Console.WriteLine(PlayerGold); */
        }
    }
}
