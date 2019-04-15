using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin4
{
    class Begin4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаметр");
            double diameter = double.Parse(Console.ReadLine());
            if (diameter < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Диаметр не может быть отрицательным");
                return;
            }

            double p = 3.14;
            double length = p * diameter;
            Console.WriteLine($"L={length}");
            Console.ReadLine();
        }
    }
}
