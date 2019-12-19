using System;


namespace opg_evil_xmas_adventure
{
    class Obstacles
    {
        
        
       
        public void AnObstacle() // Decides what the player runs in to next
        {
            MonsterObstacle monsterObstacle = new MonsterObstacle();
            Npc npc = new Npc();

            Random random = new Random();

            int randomNumber = random.Next(1, 4);
            
            if (randomNumber == 1)
            {
                monsterObstacle.MonsterEncounter();           
            }
           
            else if (randomNumber == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Nothing happens... \nBut you do feel a nice cool breeze \ncoming from down the road");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
            else if (randomNumber == 3)
            {
                npc.NpcEncounter();
            }
        }        
    }
}
