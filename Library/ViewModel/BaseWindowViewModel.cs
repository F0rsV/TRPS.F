namespace Library.ViewModel
{
    public class BaseWindowViewModel
    {
        public ClientViewModel ClientViewModel { get; set; }
        public BookViewModel BookViewModel { get; set; }

        public BaseWindowViewModel(Business.IClientService clientService, Business.IBookService bookService)
        {
            ClientViewModel = new ClientViewModel(clientService); ;
            BookViewModel = new BookViewModel(bookService);
        }
    }
}