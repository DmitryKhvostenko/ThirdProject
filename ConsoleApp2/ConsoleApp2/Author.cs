using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Author
    {
        public string AuthorName { get; set; }
        public void Show()
        {
            Console.WriteLine("Автор книги: "+AuthorName);
        }
        
    }
}
