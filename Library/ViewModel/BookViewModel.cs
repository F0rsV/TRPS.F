using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Library.ViewModel
{
    public class BookViewModel : INotifyPropertyChanged
    {
        private readonly Data.IUnitOfWork unit;

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
                            searchedList = unit.BookRepository.FindById(BookSearchInput);
                        }
                        else if (BookSearchFilter == "за назвою")
                        {
                            searchedList = unit.BookRepository.FindByName(BookSearchInput);
                        }
                        else if (BookSearchFilter == "за автором")
                        {
                            searchedList = unit.BookRepository.FindByAuthor(BookSearchInput);
                        }

                        searchedList.ForEach(x => ListOfSearchedBooks.Add(x));
                    });
            }
        }


        public BookViewModel(Data.IUnitOfWork unit)
        {
            this.unit = unit;

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