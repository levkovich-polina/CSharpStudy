using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A");
            int side1 = int.Parse(Console.ReadLine());
            if (side1 < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Сторона не может быть отрицательным");
                return;
            }

            Console.WriteLine("Введите сторону C");
            int side2 = int.Parse(Console.ReadLine());
            if (side2 < side1)
            {
                Console.WriteLine("Вы ввели число меньше. Сторона должна быть больше стороны A");
                return;
            }

            Console.WriteLine("Введите сторону B");
            int side3 = int.Parse(Console.ReadLine());
            if (side3 < side2)
            {
                Console.WriteLine("Вы  ввели число меньше. Сторона должна быть больше стороны C");
                return;
            }

           

            int a = side2 - side1;
            Console.WriteLine($"AC={a}");
            int b = side3 - side2;
            Console.WriteLine($"BC={b}");

            Console.ReadLine();
        }
    }
}
