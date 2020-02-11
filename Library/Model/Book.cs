using System;

namespace Library.Model
{
    public enum BookTheme
    {
        Fiction,
        Romance,
        Poem
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; } //change
        public BookTheme Theme { get; set; }
        public int Id { get; set; }

        public Book()
        {

        }
    }
}
