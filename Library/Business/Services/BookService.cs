using System.Collections.Generic;
using System.Linq;
using Library.Model;

namespace Library.Business
{
    public class BookService : IBookService
    {
        private readonly Data.IUnitOfWork unit;

        public BookService(Data.IUnitOfWork unit)
        {
            this.unit = unit;
        }


        public List<Book> FindById(int id)
        {
            return unit.BookRepository.GetAll().ToList().FindAll(x => x.Id == id);
        }

        public List<Book> FindByName(string name)
        {
            return unit.BookRepository.GetAll().ToList().FindAll(x => x.Name == name);

        }

        public List<Book> FindByAuthor(string authorName)
        {
            return unit.BookRepository.GetAll().ToList().FindAll(x => x.Author.FullName == authorName);

        }
    }
}