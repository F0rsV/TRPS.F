using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Data;
using Library.ViewModel;

namespace Library.Model
{
    public class LibraryManager
    {
        private readonly IDataLoader dataLoader;
        public ClientViewModel ClientViewModel { get; set; }
        public BookViewModel BookViewModel { get; set; }

        public LibraryManager()
        {
            ClientViewModel = new ClientViewModel();;
            BookViewModel = new BookViewModel();
        }

        public LibraryManager(string path, IDataLoader dL)
        {
            this.dataLoader = dL;
            LibraryManager libraryManager = (LibraryManager)dataLoader.LoadData(path);

            ClientViewModel = libraryManager.ClientViewModel;
            BookViewModel = libraryManager.BookViewModel;
        }



    }
}