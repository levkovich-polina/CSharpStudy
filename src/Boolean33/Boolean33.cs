using System;

namespace Boolean33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите сторону a");
            var a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Нужно ввести положительное число");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите сторону b");
            var b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Нужно ввести положительное число");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите сторону c");
            var c = double.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Нужно ввести положительное число");
                Console.ReadLine();
                return;
            }

            bool canTriangleExist = (a + b > c) && (a + c > b) && (b + c > a);
            Console.WriteLine($"Треугольник существует?-{canTriangleExist}");
            Console.ReadLine();
        }
    }
}
