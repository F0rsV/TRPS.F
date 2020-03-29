namespace Library.Configs
{
    public class ViewModelCreator : ICreator<ViewModel.BaseWindowViewModel>
    {
        private readonly Data.LibraryContext libraryContext;

        public ViewModelCreator()
        {
            libraryContext = new Data.LibraryContext();
        }


        public ViewModel.BaseWindowViewModel Create()
        {
            Data.IUnitOfWork unitOfWork = new Data.UnitOfWork(libraryContext);

            Business.IClientService clientService = new Business.ClientService(unitOfWork);
            Business.IBookService bookService = new Business.BookService(unitOfWork);

            return new ViewModel.BaseWindowViewModel(clientService, bookService);
        }
    }
}