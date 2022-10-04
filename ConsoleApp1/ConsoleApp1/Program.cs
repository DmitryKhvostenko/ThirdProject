using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вторую сторону прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine("Площадь: "+ rec.Area +" Пермиетр: "+ rec.Perimeter);
            Console.ReadKey();
        }
    }
}