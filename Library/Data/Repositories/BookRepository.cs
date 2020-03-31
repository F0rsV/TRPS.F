using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext context;


        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }


        public List<Model.Book> FindById(string id)
        {
            int searchId = -1;
            if (!string.IsNullOrEmpty(id) && id.All(char.IsDigit))
            {
                searchId = Convert.ToInt32(id);
            }

            return context.Books.ToList().FindAll(x => x.Id == searchId);
        }

        public List<Model.Book> FindByName(string name)
        {
            return context.Books.ToList().FindAll(x => x.Name == name);
        }

        public List<Model.Book> FindByAuthor(string authorName)
        {
            return context.Books.ToList().FindAll(x => x.Author.FullName == authorName);
        }

    }
}