using System;

namespace Boolean30
{
    class Boolean30
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

            bool isTriangleEquilateral = (a == b) && (b == c);
            Console.WriteLine($"Является треугольник равносторинним?-{isTriangleEquilateral}");
            Console.ReadLine();
        }
    }
}
