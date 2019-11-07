using System;
using System.Collections.Generic;

namespace Library_project
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //convert classes to objects
            Library library = new Library();
            LibSwitch libSwitch = new LibSwitch();

            Console.WriteLine(library.Welcome());
            Console.WriteLine("");

            //overwiew of current books
            Console.WriteLine("Amount: " + library.books[0].Amount + " Title " + library.books[0].Title + " Pages " + library.books[0].Pages);
            Console.WriteLine("Amount: " + library.books[1].Amount + " Title " + library.books[1].Title + " Pages " + library.books[1].Pages);
            Console.WriteLine("Amount: " + library.books[2].Amount + " Title " + library.books[2].Title + " Pages " + library.books[2].Pages);
           
            //calls my object classes that contains my switch elements
            libSwitch.BookBurrowSwitch(library);
            libSwitch.BookReturnSwitch(library);
        }

        
    }
}
