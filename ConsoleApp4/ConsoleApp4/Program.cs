using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(70325, "Хвостенко Дмитрий", "Слава Украинов", 24);
            inv.Article = "Шины";
            inv.Quantity = 37;
            Console.WriteLine(inv.ToString());
            Console.ReadKey();
        }
    }
}
