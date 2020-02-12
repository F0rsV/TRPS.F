using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class Client
    {
        public int LibraryCardId { get; set; }
        public string Name { get; set; }
        public int PassportId { get; set; }
        public List<Book> BooksList { get; set; }

        public Client()
        {
            BooksList = new List<Book>();
        }

        public List<Book> GetBooksThatClientHas()
        {
            return BooksList;
        }
    }
}
