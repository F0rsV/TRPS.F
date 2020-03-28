using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Model
{
    public class Book
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public Author Author { get; set; }

    }
}
