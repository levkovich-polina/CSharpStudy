using System;

namespace Begin19
{
    class Begin19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точку x1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите точку y1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите точку x2");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите точку y2");
            double y2 = double.Parse(Console.ReadLine());

            double length = Math.Abs(x2 - x1);
            double height = Math.Abs(y2 - y1);

            Console.WriteLine($"P={(length + height) * 2}");
            Console.WriteLine($"S={height * length}");

            Console.ReadLine();
        }
    }
}