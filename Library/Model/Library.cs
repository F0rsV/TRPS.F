using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class Library
    {
        public List<Book> ListOfBooks { get; set; }
        public List<Client> ListOfClients { get; set; }

        public Library()
        {

        }
    }
}