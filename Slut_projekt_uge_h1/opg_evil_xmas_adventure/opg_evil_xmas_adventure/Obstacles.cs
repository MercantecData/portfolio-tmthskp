using System;


namespace opg_evil_xmas_adventure
{
    class Obstacles
    {
        
        
       
        public void AnObstacle() // Decides what the player runs in to next
        {
            MonsterObstacle monsterObstacle = new MonsterObstacle();
            
            Random random = new Random();

            int randomNumber = random.Next(1, 4);
            
            if (randomNumber == 1)
            {
                monsterObstacle.MonsterEncounter();           
            }
           
            else if (randomNumber == 2)
            {
                Console.WriteLine("Nothing happens");
            }
            
            else if (randomNumber == 3)
            {
                Console.WriteLine("You see nothing");
            }
        }        
    }
}
