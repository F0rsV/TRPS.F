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

        public Client(int libraryCardId, string name, int passportId)
        {
            BooksList = new List<Book>();

            LibraryCardId = libraryCardId;
            Name = name;
            PassportId = passportId;
        }

        //maybe delete this sh
        public List<Book> GetBooksThatClientHas()
        {
            return BooksList;
        }
    }
}
