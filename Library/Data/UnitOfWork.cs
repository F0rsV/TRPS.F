namespace Library.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly LibraryContext context;
        private IBookRepository bookRepository;
        private IClientRepository clientRepository;

        public UnitOfWork(LibraryContext context)
        {
            this.context = context;
        }

        public IBookRepository BookRepository
        {
            get
            {
                return bookRepository ??= new BookRepository(context);
            }
        }

        public IClientRepository ClientRepository
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