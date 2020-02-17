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


        public List<Book> FindBooks(int id)
        {
            return ListOfBooks.FindAll(x => x.Id == id);
        }

        public List<Book> FindBooks(string name)
        {
            return ListOfBooks.FindAll(x => x.Name == name);
        }

        public List<Book> FindBooks(Author author)
        {
            return ListOfBooks.FindAll(x => x.Author == author);
        }



    }
}