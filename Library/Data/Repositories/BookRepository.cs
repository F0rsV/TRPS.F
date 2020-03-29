using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class BookRepository : IRepository<Model.Book>
    {
        private readonly LibraryContext context;


        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Model.Book> GetAll()
        {
            return context.Books.Include(p => p.Author).ToList();
        }
    }
}