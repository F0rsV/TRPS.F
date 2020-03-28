using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

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
