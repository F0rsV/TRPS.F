using Library.Data;

namespace Library.ViewModel
{
    public class BaseWindowViewModel
    {
        public ClientViewModel ClientViewModel { get; set; }
        public BookViewModel BookViewModel { get; set; }

        public BaseWindowViewModel(IUnitOfWork unit)
        {
            ClientViewModel = new ClientViewModel(unit); ;
            BookViewModel = new BookViewModel(unit);
        }
    }
}