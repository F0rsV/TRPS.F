using System.Collections.Generic;

namespace Library.Business
{
    public interface IBookService
    {
        List<Model.Book> FindById(int id);
        List<Model.Book> FindByName(string name);
        List<Model.Book> FindByAuthor(string authorName);
    }
}