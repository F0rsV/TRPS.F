using System;
using System.Collections.Generic;
using Library.Data;

namespace Library.Model
{
    public class LibraryManager
    {
        public BookManager BookManager { get; set; }
        public ClientManager ClientManager { get; set; }
        private readonly IDataLoader dataLoader;


        public LibraryManager()
        {
            BookManager = new BookManager();
            ClientManager = new ClientManager();
        }

        public LibraryManager(string path)
        {
            dataLoader = new DataLoader();
            LibraryManager libraryManager = (LibraryManager)dataLoader.LoadData(path);

            BookManager = libraryManager.BookManager;
            ClientManager = libraryManager.ClientManager;
        }


    }
}