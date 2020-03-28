﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Library.Model;

namespace Library.ViewModel
{
    public class BookViewModel : INotifyPropertyChanged
    {
        //public List<Book> ListOfBooks { get; set; }
        private readonly Business.IBookService bookService;


        public ObservableCollection<Book> ListOfSearchedBooks { get; set; }

        private Book selectedBook;
        public Book SelectedBook
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
                        List<Book> searchedList = new List<Book>();

                        if (BookSearchFilter == "за бібліотечним номером")
                        {
                            //searchedList = ListOfBooks.FindAll(x => x.Id == Convert.ToInt32(BookSearchInput));

                            int searchId = Convert.ToInt32(BookSearchInput);
                            searchedList = bookService.FindById(searchId);
                        }
                        else if (BookSearchFilter == "за назвою")
                        {
                            //searchedList = ListOfBooks.FindAll(x => x.Name == BookSearchInput);

                            searchedList = bookService.FindByName(BookSearchInput);
                        }
                        else if (BookSearchFilter == "за автором")
                        {
                            //searchedList = ListOfBooks.FindAll(x => x.Author.FullName == BookSearchInput);

                            searchedList = bookService.FindByAuthor(BookSearchInput);
                        }

                        searchedList.ForEach(x => ListOfSearchedBooks.Add(x));
                    },
                    obj => true); //СДЕЛАТЬ ВАЛІДЕЙШ
            }
        }


        public BookViewModel(Business.IBookService bookService)
        {
            //ListOfBooks = new List<Book>();
            this.bookService = bookService;

            ListOfSearchedBooks = new ObservableCollection<Book>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}