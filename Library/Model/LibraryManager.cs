using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class LibraryManager
    {
        public BookManager BookManager { get; set; }
        public ClientManager ClientManager { get; set; }
        

        public LibraryManager()
        {
            BookManager = new BookManager();
            ClientManager = new ClientManager();
        }
    }
}