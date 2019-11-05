using System;
using System.Collections.Generic;
using System.Text;

namespace Library_project
{
    class Book
    {
        public int Amount;
        public string Title;
        public int Pages;
       

        public Book(int Amount, string Title, int Pages)
        {
            this.Amount = Amount;
            this.Title = Title;
            this.Pages = Pages;           
        }
    }
}
