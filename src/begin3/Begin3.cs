using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begin3
{
    class Begin3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Сторона прямоугольника не может быть отрицательной");
                return;
            }
            Console.WriteLine("Введите вторую сторону прямоугольника");
            int count = int.Parse(Console.ReadLine());
            if (count < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Сторона прямоугольника не может быть отрицательной");
                return;
            }

            int perimeter = (number  + count)*2;
            Console.WriteLine($"P={perimeter}");

            int square = number*count;
            Console.WriteLine($"S={square}");
            Console.ReadLine();
        }
    }
}
