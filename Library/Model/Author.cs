using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class Author
    {
        public string FullName { get; set; }

        public Author(string fullName)
        {
            FullName = fullName;
        }
        
    }
}