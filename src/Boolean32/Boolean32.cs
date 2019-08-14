using System;

namespace Boolean32
{
    class Boolean32
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите сторону a");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону b");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону c");
            var c = double.Parse(Console.ReadLine());
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;
            bool isATriangleRectangular = (c2 == a2 + b2) || (a2 == b2 + c2) || (b2 == c2 + a2);
            Console.WriteLine($"Является треуголник прямоугольным?-{isATriangleRectangular}");
            Console.ReadLine();
        }
    }
}
