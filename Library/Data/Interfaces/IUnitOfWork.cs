namespace Library.Data
{
    public interface IUnitOfWork
    {
        IBookRepository BookRepository { get; }
        IClientRepository ClientRepository { get; }

        void SaveChanges();
    }
}