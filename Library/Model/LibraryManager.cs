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
        public ClientViewModel ClientViewModel { get; set; }
        public BookViewModel BookViewModel { get; set; }
        public IDataLoader<LibraryManager> DataLoader { get; set; }

        
        public LibraryManager()
        {
            ClientViewModel = new ClientViewModel();;
            BookViewModel = new BookViewModel();
            DataLoader = new DataLoader<LibraryManager>();
        }

    }
}