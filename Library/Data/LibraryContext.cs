using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Library.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Model.Author> Authors { get; set; }
        public DbSet<Model.Book> Books { get; set; }
        public DbSet<Model.Client> Clients { get; set; }


        public LibraryContext()
        {
/*
            Database.EnsureDeleted();
            Database.EnsureCreated();
*/
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); FLUENT API
            //https://metanit.com/sharp/entityframeworkcore/2.14.php Додавання початкових даних

        }

    }
}