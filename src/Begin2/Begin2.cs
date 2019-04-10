using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin2
{
    class Begin2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата");
            int size = int.Parse(Console.ReadLine());
            if (size < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Сторона квадрата не может быть отрицательной");
                return;
            }

            int square = size * size;
            Console.WriteLine($"S={square}");
            Console.ReadLine();
        }
    }
}
