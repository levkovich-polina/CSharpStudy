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
            Console.WriteLine("Введите точку  A");
            int side1 = int.Parse(Console.ReadLine());
            

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
            
            int b = side3 - side2;
            Console.WriteLine($"AC*BC={b*a}");

            Console.ReadLine();
        }
    }
}
