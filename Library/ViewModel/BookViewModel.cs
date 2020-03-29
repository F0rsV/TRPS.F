using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Library.ViewModel
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private readonly Business.IBookService bookService;

        public ObservableCollection<Model.Book> ListOfSearchedBooks { get; set; }

        private Model.Book selectedBook;
        public Model.Book SelectedBook
        {
            get => selectedBook;
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        private string bookSearchFilter;
        public string BookSearchFilter
        {
            get => bookSearchFilter;
            set
            {
                //change maybe to dict
                bookSearchFilter = value;
                OnPropertyChanged("BookSearchFilter");
            }
        }

        private string bookSearchInput;
        public string BookSearchInput
        {
            get => bookSearchInput;
            set
            {
                bookSearchInput = value;
                OnPropertyChanged("BookSearchInput");
            }
        }

        private RelayCommand findBookCommand;
        public RelayCommand FindBookCommand
        {
            get
            {
                return findBookCommand ??= new RelayCommand(obj =>
                    {
                        ListOfSearchedBooks.Clear();
                        List<Model.Book> searchedList = new List<Model.Book>();

                        if (BookSearchFilter == "за бібліотечним номером")
                        {
                            searchedList = bookService.FindById(BookSearchInput);
                        }
                        else if (BookSearchFilter == "за назвою")
                        {
                            searchedList = bookService.FindByName(BookSearchInput);
                        }
                        else if (BookSearchFilter == "за автором")
                        {
                            searchedList = bookService.FindByAuthor(BookSearchInput);
                        }

                        searchedList.ForEach(x => ListOfSearchedBooks.Add(x));
                    });
            }
        }


        public BookViewModel(Business.IBookService bookService)
        {
            this.bookService = bookService;

            ListOfSearchedBooks = new ObservableCollection<Model.Book>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}