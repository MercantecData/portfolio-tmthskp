using System;

namespace Library_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Library welcome = new Library();
            Console.WriteLine(welcome.Welcome());
            Console.WriteLine("");

            var Book1 = new Book("Gone", 300);
            Console.WriteLine(Book1.Title);
            Console.WriteLine(Book1.Pages + " Pages ");
            Console.WriteLine("");

            var Book2 = new Book("Gone again", 200);
            Console.WriteLine(Book2.Title);
            Console.WriteLine(Book2.Pages + " Pages ");
            Console.WriteLine("");

            var Book3 = new Book("Gone again extended", 400);
            Console.WriteLine(Book3.Title);
            Console.WriteLine(Book3.Pages + " Pages ");
            Console.WriteLine("");         
        }
    }
}
