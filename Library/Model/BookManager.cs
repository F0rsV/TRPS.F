using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class BookManager
    {
        public List<Book> ListOfBooks { get; set; }

        public BookManager()
        {
            ListOfBooks = new List<Book>();
        }
    }
}