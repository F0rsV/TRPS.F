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
            //optionsBuilder.EnableSensitiveDataLogging();
            // "Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;"

            var connectionString = ConfigurationManager.ConnectionStrings["LibraryDbConnection"].ConnectionString;
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
            ;
        }

    }
}