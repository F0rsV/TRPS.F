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


        public Book FindBook(int idSearch)
        {
            return ListOfBooks.Find(x => x.Id == idSearch);
        }

        public List<Book> FindBook(string nameSearch)
        {
            return ListOfBooks.FindAll(x => x.Name == nameSearch);
        }

        public List<Book> FindBook(/*Author authorSearch*/)
        {
            //return ListOfBooks.FindAll(x => x.Author == authorSearch);
            return ListOfBooks; // CHANGE
        }


        // ПИТАННЯ ВИКЛАДАЧУ: ПошукКниги краще реалізувати так, як це зроблено зверху (перевантаження методу, чи наступним чином:

        public List<Book> FindBooks(int idSearch = -1, string nameSearch = "", string authorSearch = "")
        {
            if (idSearch >= 0)
                return ListOfBooks.FindAll(x => x.Id == idSearch);
            if (nameSearch != "")
                return ListOfBooks.FindAll(x => x.Name == nameSearch);
            if (authorSearch != "")
                return ListOfBooks.FindAll(x => x.Author == authorSearch);

            return new List<Book>();
        }

    }
}