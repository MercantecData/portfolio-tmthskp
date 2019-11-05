using System;
using System.Collections.Generic;
using System.Text;

namespace Library_project
{
    class Library
    {
        public List<Book> books = new List<Book>();
        public List<Book> borrowedBooks = new List<Book>();

        public string Welcome()
        {
            string welcome = "Welcome to the library we got these books to choose from";           
            return welcome;
        }
        public Library()
        {
            var Book1 = new Book(1, "Gone", 300);
            var Book2 = new Book(1, "Gone again", 200);
            var Book3 = new Book(1, "Gone again extended", 400);

            books.Add(Book1);
            books.Add(Book2);
            books.Add(Book3);
        }

        public void BookBurrow()
        {
            Console.WriteLine("Cool What book do you wanna burrow");
            Console.WriteLine("");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine("Nr " + (i + 1) + " Amount: " + books[i].Amount + " Title " + books[i].Title + " Pages " + books[i].Pages);
            }

            Console.WriteLine("Choose from number");
            string input = (Console.ReadLine());
            bool bConvert = Int32.TryParse(input, out int bookToBorrowIndex);
 

            if (bConvert && bookToBorrowIndex - 1 < books.Count && bookToBorrowIndex >= 0)    
            {
                borrowedBooks.Add(books[bookToBorrowIndex - 1]);
                books.RemoveAt(bookToBorrowIndex - 1);
                Console.WriteLine("\nThese books are left in library after burrow");
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine("Nr " + (i + 1) + " Amount: " + books[i].Amount + " Title " + books[i].Title + " Pages " + books[i].Pages);                   
                }
                Console.WriteLine("\nThank you. You can Burrow it for " + burrowTime + " days");
            }

            else
            {
                Console.WriteLine("No Can do. No Book");
                BookBurrowSwitch();
            }
        }
        public void BookReturn()
        {
            Console.WriteLine("Okay What book do you wanna Return? ");
            for (int i = 0; i <borrowedBooks.Count; i++)
            {
                Console.WriteLine("Nr " + (i + 1) + " Amount: " + borrowedBooks[i].Amount + " Title " + borrowedBooks[i].Title + " Pages " + borrowedBooks[i].Pages);
            }
            
            Console.WriteLine("Choose from number");
            string input2 = (Console.ReadLine());
            bool bConvert2 = Int32.TryParse(input2, out int bookToReturnIndex);
            if (bConvert2 && bookToReturnIndex - 1 < borrowedBooks.Count && bookToReturnIndex >= 0)
            {
                books.Add(borrowedBooks[bookToReturnIndex - 1]);
                borrowedBooks.RemoveAt(bookToReturnIndex - 1);

                for (int i = 0; i < borrowedBooks.Count; i++)
                {
                    Console.WriteLine("Nr " + (i + 1) + " Amount: " + borrowedBooks[i].Amount + " Title " + borrowedBooks[i].Title + " Pages " + borrowedBooks[i].Pages);
                }
                Console.WriteLine("\nThank you have a nice day");
            }
            
            else
            {
                Console.WriteLine("No Can do. No Book");
                BookReturnSwitch();
            }
        }

        public void BookBurrowSwitch()
        {
            Console.WriteLine("\nDo you wanna borrow a book?");
            Console.WriteLine("Yes \nNo");
            string userResponse = Console.ReadLine();
            switch (userResponse.ToLower())
            {
                case "yes":
                case "y":
                    BookBurrow();
                    break;

                case "no":
                case "n":
                    Console.WriteLine("okay Then ");
                    break;

                default:
                    Console.WriteLine("I'm sorry, I didn't understand that!");
                    BookBurrowSwitch();
                    break;
            }
        }

        public void BookReturnSwitch()
        {
            Console.WriteLine("\nDo you wanna return a book?");
            Console.WriteLine("Yes \nNo");
            string userResponse1 = Console.ReadLine();
            switch (userResponse1.ToLower())
            {
                case "yes":
                case "y":
                    BookReturn();
                    break;

                case "no":
                case "n":
                    
                    ExtendBurrowTimeSwitch();
                    break;

                default:
                    Console.WriteLine("I'm sorry, I didn't understand that!");
                    BookReturnSwitch();
                    break;
            }
        }
        
        public int burrowTime = 5;
                
        public void ExtendBurrowTimeSwitch()
        {
            Console.WriteLine("\nDo you wanna Change burrow time?");
            Console.WriteLine("Yes \nNo");
            string userResponse2 = Console.ReadLine();
            switch (userResponse2.ToLower())
            {
                case "yes":
                case "y":
                    Console.WriteLine("How many days do you wanna burrow it?");
                    string extendTime = (Console.ReadLine());
                    try { 
                    burrowTime = Convert.ToInt32(extendTime);
                    Console.WriteLine("The book can now be burrowed for " + burrowTime + " days ");
                    Console.WriteLine("\nHave a Nice day");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("No valid number");
                        ExtendBurrowTimeSwitch();
                    }
                    break;

                case "no":
                case "n":
                    Console.WriteLine("Okay, then Have a good day");
                    break;

                default:
                    Console.WriteLine("I'm sorry, I didn't understand that!");
                    ExtendBurrowTimeSwitch();
                    break;
            }
        }
    }
}
