using System;
using System.Collections.Generic;
using System.Text;

namespace Library_project
{
    class Book
    {
        //Parameters for book data
        public int Amount;
        public string Title;
        public int Pages;
       
        //constructor of book by use of parameters
        public Book(int Amount, string Title, int Pages)
        {
            this.Amount = Amount;
            this.Title = Title;
            this.Pages = Pages;           
        }
    }
}
