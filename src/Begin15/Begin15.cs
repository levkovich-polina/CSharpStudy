using System;

namespace Begin15
{
    class Begin15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите площадь круга");
            int square = int.Parse(Console.ReadLine());
            if (square < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Площадь не может быть отрицательной");
                return;
            }

            double p = 3.14;
            double diameter = Math.Sqrt((square * 4) / p);
            Console.WriteLine($"D={diameter}");

            double length = p * diameter;
            Console.WriteLine($"L={length}");

            Console.ReadLine();
        }
    }
}