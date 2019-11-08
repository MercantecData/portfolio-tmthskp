using System;

namespace opg_Metoder_program_menu
{
    class Program
    {
        /****** Guess a number Game code ******/
        private static void NumberGame() //number game
        {
            Random random = new Random(); //number randomizer
            while (true)
            {
                int randomNumber = random.Next(1, 6); // randomly  picks a number between chosen range (1, 6)
                bool retry = true; // declares variables to store the Boolean values: true and false varibel true run while loop
                while (true)
                {
                    Console.Write("Gæt et tal imellem 1 and 6: ");
                    int input = Convert.ToInt32(Console.ReadLine()); // convert input to a 32 bit int

                    if (input < randomNumber) // lower than varibel 
                    {
                        Console.WriteLine("For lav, prøv igen. ");                     
                        continue; // continue forces the next state of while loop
                    }

                    else if (input > randomNumber) // higher than varibel
                    {
                        Console.WriteLine("For høj, prøv igen. ");
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Tillykke. godt gættet!");
                        Console.WriteLine("vil du prøve igen? j/n");
                        string answer = Console.ReadLine();
                        if (answer != "j") // if anwers not equal to j 
                        {
                            retry = false; // statement false 
                        }
                        break; // forces state to stop
                    }

                }
                if (!retry) break; // if retry false end program. !retry = not true
            }
        }

        /****** 8Ballgame code ******/
        private static void Game8Ball() // 8ballgame
        {
            bool run = true;

            Random rng = new Random();
            string[] WordList = { "yes", "no", "Maaayyyybe", "What do you think?", "Metal", "The Answer is 3, 6, 9", "call 666", "Satan is real!", "Are you?", "Look inside", "..." };

            while (run)
            {
                Console.Write("\nAsk your question: ");
                string message = Console.ReadLine();
                int index = rng.Next(1,WordList.Length);

                if (message == "exit")
                {
                    run = false;
                }

                else if (message.ToLower() == "fuck")
                {
                    Console.WriteLine("hmph You Wish Bitch");
                }

                else if (message.ToLower() == "fuck you")
                {
                    Console.WriteLine("LANGUAGE!!!");
                }
                else
                {
                    Console.WriteLine(WordList[index]);
                }
            }
        }

        /****** Menu Start code ******/
        static void Main(string[] args)
        {
            
            bool runing = true;

            while (runing)
            {
                Console.WriteLine("\nChoose game");
                Console.WriteLine("1 = Number Game, 2 = 8Ball Game, 3 = Exit");

                int select = int.Parse(Console.ReadLine());
                if(select == 1)
                {
                    NumberGame();  
                }

                else if (select == 2)
                {
                    Game8Ball();
                }

                else if (select == 3)
                {
                    runing = false;
                }
            }
        }
    }
}
