using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin39
{
    class Begin39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент A");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Коэффициент A не должен быть равен 0");
                return;
            }

            Console.WriteLine("Введите коэффициент B");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент C");
            double c = double.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Дискриминант отрицательный");
                Console.WriteLine("Действительных корней нет");
                Console.ReadLine();
            }
            else if (d == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine($"x1=x2={x}");
                Console.ReadLine();
            }
            else
            {
                double x1 = (-(b) + Math.Sqrt(d)) / 2 * a;
                double x2 = (-(b) - Math.Sqrt(d)) / 2 * a;
                Console.WriteLine($"x1={x1}");
                Console.WriteLine($"x2={x2}");
            }

            Console.ReadLine();
        }
    }
}