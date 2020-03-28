namespace Library.Data
{
    public interface IUnitOfWork
    {
        IRepository<Model.Book> BookRepository { get; }
        IRepository<Model.Client> ClientRepository { get; }

        void SaveChanges();
    }
}