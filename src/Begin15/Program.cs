using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin15
{
    class Begin15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь круга");
            int square = int.Parse(Console.ReadLine());
            if (square < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Площадь не может быть отрицательной");
                return;
            }

            double p = 3.14;
            double d1 = Math.Sqrt((square * 4)/p);
            Console.WriteLine($"D={d1}");

            double l1 = p * d1;
            Console.WriteLine($"L={l1}");


            Console.ReadLine();
        }
    }
}
