using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library.Business;
using Library.Data;
using Microsoft.EntityFrameworkCore;


namespace Library.View
{
    /// <summary>
    /// Логика взаимодействия для BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        public BaseWindow()
        {
            Data.LibraryContext libraryContext = new Data.LibraryContext();

            /*
                        Model.Author author1 = new Model.Author(){FullName = "Author1Name"};

                        Model.Book book1 = new Model.Book() {Name = "name1", Author = author1};
                        Model.Book book2 = new Model.Book() {Name = "name2", Author = author1};

                        Model.Client client1 = new Model.Client() {Name = "ClientName1", PassportId = 1321};
                        client1.BooksList.Add(book2);


                        db.Authors.Add(author1);
                        db.Books.Add(book1);
                        db.Books.Add(book2);
                        db.Clients.Add(client1);
                        db.SaveChanges();

            */

            //Data.IRepository<Model.Book> bookRepository = new Data.BookRepository(db);
            //List<Model.Book> allBooks = bookRepository.GetAll().ToList();

            //Books.Include(p => p.Author).*вся фігня далі*

            string name = libraryContext.Books.Include(p => p.Author).ToList()[0].Author.FullName;

            //MessageBox.Show(name);

            ;

            Data.IUnitOfWork unitOfWork = new UnitOfWork(libraryContext);

            Business.IClientService clientService = new ClientService(unitOfWork);
            Business.IBookService bookService = new BookService(unitOfWork);


            DataContext = new ViewModel.BaseWindowViewModel(clientService, bookService);
            InitializeComponent();
        }

    }
}
