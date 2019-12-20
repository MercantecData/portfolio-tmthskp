using System;


namespace opg_evil_xmas_adventure
{
    class EnemyEncounters
    {
        /***** Global monster stats variabler *****/
        public int MonsterHP;
        public int MonsterDMG;
        
        Random random = new Random(); //number randomizer
      
        /*****************Monster Stats*********************/
        public bool AdultReindeer() 
        {      
            MonsterHP = 10;
            MonsterDMG = random.Next(1, 6);
            return true;
        } 
        
        public bool XmasGnome() 
        {
            MonsterHP = 12;
            MonsterDMG = random.Next(1, 6);
            return true;
        }   

        public bool XmasElf()
        {
            MonsterHP = 15;
            MonsterDMG = random.Next(1, 6) * 2;
            return true;
        }
        
          
    }
}
