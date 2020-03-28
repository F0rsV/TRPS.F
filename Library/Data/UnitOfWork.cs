namespace Library.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly LibraryContext context;
        private IRepository<Model.Book> bookRepository;
        private IRepository<Model.Client> clientRepository;

        public UnitOfWork(LibraryContext context)
        {
            this.context = context;
        }

        public IRepository<Model.Book> BookRepository
        {
            get
            {
                return bookRepository ??= new BookRepository(context);
            }
        }

        public IRepository<Model.Client> ClientRepository
        {
            get
            {
                return clientRepository ??= new ClientRepository(context);
            }
        }
        

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}