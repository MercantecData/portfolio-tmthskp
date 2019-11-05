﻿using System;
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
            Console.WriteLine("cool What book do you wanna burrow");

            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine((i + 1) + "Amount: " + books[i].Amount + " Title " + books[i].Title + " Pages " + books[i].Pages);
            }

            Console.WriteLine("choose from number");
            string input = (Console.ReadLine());
            Int32.TryParse(input, out int bookToBorrowIndex);
            if (bookToBorrowIndex - 1 >= books.Count)
            {
                Console.WriteLine("No Can do No Book");
            }
            else
            {
                borrowedBooks.Add(books[bookToBorrowIndex - 1]);
                books.RemoveAt(bookToBorrowIndex - 1);

                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine((i + 1) + "Amount: " + books[i].Amount + " Title " + books[i].Title + " Pages " + books[i].Pages);
                }

            }
        }
        public void BookReturn()
        {
            Console.WriteLine("Okay What book do you wanna Return? ");
            for (int i = 0; i <borrowedBooks.Count; i++)
            {
                Console.WriteLine((i + 1) + "Amount: " + borrowedBooks[i].Amount + " Title " + borrowedBooks[i].Title + " Pages " + borrowedBooks[i].Pages);
            }
            Console.WriteLine("choose from number");
            string input2 = (Console.ReadLine());
            Int32.TryParse(input2, out int bookToReturnIndex);
            if (bookToReturnIndex - 1 >= borrowedBooks.Count)
            {
                Console.WriteLine("No Can do No Book");
            }

            else
            {
                books.Add(borrowedBooks[bookToReturnIndex - 1]);
                borrowedBooks.RemoveAt(bookToReturnIndex - 1);

                for (int i = 0; i < borrowedBooks.Count; i++)
                {
                    Console.WriteLine((i + 1) + "Amount: " + borrowedBooks[i].Amount + " Title " + borrowedBooks[i].Title + " Pages " + borrowedBooks[i].Pages);
                }
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
            Console.WriteLine("\nDo you wanna return a book then?");
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
                    Console.WriteLine("Okay, then Have a good day");
                    break;

                default:
                    Console.WriteLine("I'm sorry, I didn't understand that!");
                    BookReturnSwitch();
                    break;
            }
        }

    }
}
