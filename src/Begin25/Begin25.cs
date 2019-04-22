using System;

namespace Begin25
{
    class Begin25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            double x = double.Parse(Console.ReadLine());

            double y = 3 * x * x * x * x * x * x - 6 * x * x - 7;
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}