using System.Collections.Generic;
using System.Linq;

namespace Library.Data
{
    public class BookRepository : IRepository<Model.Book>
    {
        private LibraryContext context;

        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Model.Book> GetAll()
        {
            return context.Books.ToList();
        }
    }
}