using System;


namespace opg_evil_xmas_adventure
{
    class Obstacles
    {
        MonsterObstacle monsterObstacle = new MonsterObstacle();
        
       
        public void AnObstacle() // Decides what the player runs in to next
        {
            
            Random random = new Random();

            int randomNumber = random.Next(1, 4);
            
            if (randomNumber == 1)
            {
                monsterObstacle.MonsterEncounter();
                //Console.WriteLine("Nothing happens");
            }
            else if (randomNumber == 2)
            {
                monsterObstacle.MonsterEncounter();
            }
            else if (randomNumber == 3)
            {
                monsterObstacle.MonsterEncounter();
                //Console.WriteLine("You see nothing");
            }
        }


        
    }
}
