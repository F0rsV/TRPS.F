using System.Collections.Generic;

namespace Library.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassportId { get; set; }
        public List<Book> BooksList { get; set; }

        public Client()
        {
            BooksList = new List<Book>();
        }
    }
}
