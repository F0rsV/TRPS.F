using System.Collections.Generic;


namespace Library.Data
{
    public interface IBookRepository
    {
        List<Model.Book> FindById(string id);
        List<Model.Book> FindByName(string name);
        List<Model.Book> FindByAuthor(string authorName);

    }
}