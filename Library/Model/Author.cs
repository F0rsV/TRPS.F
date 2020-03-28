using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

    }
}