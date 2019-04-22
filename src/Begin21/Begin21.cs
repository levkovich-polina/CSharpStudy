using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin21
{
    class Begin21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите x2");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y2");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите x3");
            double x3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите y3");
            double y3 = double.Parse(Console.ReadLine());

            double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double c = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"S={s}");
            Console.ReadLine();
            
        }
    }
}