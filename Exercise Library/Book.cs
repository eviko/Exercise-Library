using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Library
{
    class Book
    {
        public string title { get; private set; }
        public string author { get;  set; }
        public string id { get;  set; }

        public Book(string title,string author)
            {
                this.title = title;
                this.author = author;
                this.id = "";
            }
        
    }
}
