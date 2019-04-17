using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точку  x1");
            int x1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Введите точку y1");
            int y1 = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Введите точку x2");
            int x2 = int.Parse(Console.ReadLine());
            if (x2 < x1)
            {
                Console.WriteLine("Вы  ввели число меньше. X2 должна быть больше x1");
                return;
            }
            Console.WriteLine("Введите точку y2");
            int y2 = int.Parse(Console.ReadLine());
            if (y2 < y1)
            {
                Console.WriteLine("Вы  ввели число меньше. Y2 должна быть больше y1");
                return;
            }


            int a = x2-x1;

            int b = y2 - y1;
            Console.WriteLine($"P={(a+b)*2}");
            Console.WriteLine($"S={b * a}");

            Console.ReadLine();
        }
    }
}
