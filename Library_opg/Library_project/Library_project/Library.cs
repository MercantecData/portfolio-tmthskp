using System;
using System.Collections.Generic;
using System.Text;

namespace Library_project
{
    class Library
    {
        //convert classes to objects
        public List<Book> books = new List<Book>();
        public List<Book> borrowedBooks = new List<Book>();
        LibText text = new LibText();
        LibSwitch switches = new LibSwitch();
        public int burrowTime = 5; // public variable for burrow time

        public string Welcome()
        {
            string welcome = "Welcome to the library we got these books to choose from \nTake a Look at our sortments of books available";           
            return welcome;
        }

        /********* Book Data Commit *********/
        public Library()
        {
            Book Book1 = new Book(1, "Gone", 300);
            Book Book2 = new Book(1, "Gone again", 200);
            Book Book3 = new Book(1, "Gone again extended", 400);

            books.Add(Book1);
            books.Add(Book2);
            books.Add(Book3);
        }
 
        /********* Book burrow part *********/
        public void BookBurrow()
        {
            text.MyBurrowText1();
            for (int i = 0; i < books.Count; i++) // For each element in the list print from method MyBurrowText2
            {
                text.MyBurrowText2(this, i);
            }

            string input = text.MyBurrowText3();
            bool bConvert = Int32.TryParse(input, out int bookToBorrowIndex); //converts input string to a Int32 

            if (bConvert && bookToBorrowIndex - 1 < books.Count && bookToBorrowIndex >= 0)    
            {
                borrowedBooks.Add(books[bookToBorrowIndex - 1]);
                books.RemoveAt(bookToBorrowIndex - 1);
                text.MyBurrowText4();
                for (int i = 0; i < books.Count; i++)
                {
                    text.MyBurrowText2(this, i); // calls data from this library                                
                }
                text.MyBurrowText5(this);
            }

            else
            {
                text.MyBurrowText6();
                switches.BookBurrowSwitch(this);
            }
        }

        /********* Book return part *********/
        public void BookReturn()
        {
            text.MyBurrowText7();
            for (int i = 0; i <borrowedBooks.Count; i++)
            {
                text.MyBurrowText8(this, i);               
            }

            string input2 = text.MyBurrowText3();
            bool bConvert2 = Int32.TryParse(input2, out int bookToReturnIndex);
            if (bConvert2 && bookToReturnIndex - 1 < borrowedBooks.Count && bookToReturnIndex >= 0)
            {
                books.Add(borrowedBooks[bookToReturnIndex - 1]);
                borrowedBooks.RemoveAt(bookToReturnIndex - 1);

                for (int i = 0; i < borrowedBooks.Count; i++)
                {
                    text.MyBurrowText8(this, i);
                    
                }
                text.MyBurrowText9();
            }
            
            else
            {
                text.MyBurrowText6();
                switches.BookReturnSwitch(this);
            }
        }

       
    }
}
