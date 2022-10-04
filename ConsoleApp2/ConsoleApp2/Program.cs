using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book;
            Console.WriteLine("Введите название книги:");
            string BookName = Console.ReadLine();
            Console.WriteLine("Введите автора книги:");
            string BookAuthor = Console.ReadLine();
            Console.WriteLine("Введите содержание книги: ");
            string content = Console.ReadLine();
            book = new Book(BookAuthor,BookName,content);
            book.Show();
            Console.ReadKey();
        }
    }
}
