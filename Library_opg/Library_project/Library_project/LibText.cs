using System;
using System.Collections.Generic;
using System.Text;

namespace Library_project
{
    class LibText
    {
      
        public void MyBurrowText1()
        {
            Console.WriteLine("Cool What book do you wanna burrow");
            Console.WriteLine("");
        }

        public void MyBurrowText2(Library library, int i)
        {
            Console.WriteLine("Nr " + (i + 1) + " Amount: " + library.books[i].Amount + " Title " + library.books[i].Title + " Pages " + library.books[i].Pages);
        }

        public string MyBurrowText3()
        {
            Console.WriteLine("Choose from number");
            string input = Console.ReadLine();
            return input;
        }

        public void MyBurrowText4()
        {
            Console.WriteLine("\nThese books are left in library after burrow");
        }

        public void MyBurrowText5(Library library)
        {
            Console.WriteLine("\nThank you. You can Burrow it for " + library.burrowTime + " days");
        }
        public void MyBurrowText6()
        {
            Console.WriteLine("No Can do. No Book");
        }

        public void MyBurrowText7()
        {
            Console.WriteLine("Okay What book do you wanna Return? ");
        }

        public void MyBurrowText8(Library library, int i)
        {
            Console.WriteLine("Nr " + (i + 1) + " Amount: " + library.borrowedBooks[i].Amount + " Title " + library.borrowedBooks[i].Title + " Pages " + library.borrowedBooks[i].Pages);
        }

        public void MyBurrowText9()
        {
            Console.WriteLine("\nThank you have a nice day");
        }

        public void MyBurrowText10()
        {
            Console.WriteLine("No Can do. No Book");
        }

        public string MySwitchText1()
        {
            Console.WriteLine("\nDo you wanna borrow a book?");
            Console.WriteLine("Yes \nNo");
            string userResponse = Console.ReadLine();
            return userResponse;
        }
        public void MySwitchText2()
        {
            Console.WriteLine("okay Then ");
        }

        public void MySwitchText3()
        {
            Console.WriteLine("I'm sorry, I didn't understand that!");
        }

        public string MySwitchText4()
        {
            Console.WriteLine("\nDo you wanna return a book?");
            Console.WriteLine("Yes \nNo");
            string userResponse1 = Console.ReadLine();
            return userResponse1;
        }

        public void MySwitchText5()
        {
            Console.WriteLine("I'm sorry, I didn't understand that!");
        }

        public string MySwitchText6()
        {
            Console.WriteLine("\nDo you wanna Change burrow time?");
            Console.WriteLine("Yes \nNo");
            string userResponse2 = Console.ReadLine();
            return userResponse2;
        }
        public string MySwitchText7() 
        { 
            Console.WriteLine("How many days do you wanna burrow it?");
            string extendTime = (Console.ReadLine());
            return extendTime;
        }
        
        public void MySwitchText8(Library lib)
        {
            Console.WriteLine("The book can now be burrowed for " + lib.burrowTime + " days ");
            Console.WriteLine("\nHave a Nice day");
        }

        public void MySwitchText9()
        {
            Console.WriteLine("No valid number");
        }
        public void MySwitchText10()
        {
            Console.WriteLine("Okay, then Have a good day");
        }

        public void MySwitchText11()
        {
            Console.WriteLine("I'm sorry, I didn't understand that!");
        }

    }
}
