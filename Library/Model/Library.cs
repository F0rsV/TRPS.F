using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class Library
    {
        public BookManager BookManager { get; set; }
        public ClientManager ClientManager { get; set; }

        public Library()
        {
            BookManager = new BookManager();
            ClientManager = new ClientManager();
        }
    }
}