using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double radius = double.Parse(Console.ReadLine());
            if (radius  < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Радиус не может быть отрицательным");
                return;
            }

            double p = 3.14;
            double length = 2 * p * radius;
            Console.WriteLine($"L={length}");
            double square = p * radius * radius;
            Console.WriteLine($"S={square}");

            Console.ReadLine();
        }
    }
}
