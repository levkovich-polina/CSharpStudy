using System;

namespace Begin18
{
    class Begin18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату точки A");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату точки C");
            double c = double.Parse(Console.ReadLine());
            if (c < a)
            {
                Console.WriteLine("Координата точки C должна быть больше координаты точки A");
                return;
            }

            Console.WriteLine("Введите координату точки B");
            double b = double.Parse(Console.ReadLine());
            if (b < c)
            {
                Console.WriteLine("Координата точки B должна быть больше координаты точки C");
                return;
            }

            double ac = c - a;
            double bc = b - c;

            Console.WriteLine($"AC*BC={bc * ac}");

            Console.ReadLine();
        }
    }
}