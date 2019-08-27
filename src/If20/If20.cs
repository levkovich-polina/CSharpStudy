using System;

namespace If20
{
    class If20
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число C");
            var c = double.Parse(Console.ReadLine());

            double ab = Math.Abs(b - a);
            double ac = Math.Abs(c - a);

            if (ac > ab)
            {
                Console.WriteLine($"Точка B ближе к точке A");
                Console.WriteLine($"Раcстояние от точки В до точки А = {ab}");
            }
            else
            {
                Console.WriteLine($"Точка С ближе к точке А");
                Console.WriteLine($"Раcстояние от точки C до точки А = {ac}");
            }

            Console.ReadLine();
        }
    }
}
