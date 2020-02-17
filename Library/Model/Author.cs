using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class Author
    {
        public string FullName { get; set; }
        //and so on...

        public Author(string fullName)
        {
            FullName = fullName;
        }
        
    }
}