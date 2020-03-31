using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Model.Author> Authors { get; set; }
        public DbSet<Model.Book> Books { get; set; }
        public DbSet<Model.Client> Clients { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}