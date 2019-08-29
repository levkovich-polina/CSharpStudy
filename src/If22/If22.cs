using System;

namespace If22
{
    class If22
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите координату X");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y");
            var y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"1 координатная четверть");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"2 координатная четверть");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"3 координатная четверть");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"4 координатная четверть");
            }
            else
            {
                Console.WriteLine($"Точка лежит на координатной оси");
            }

            Console.ReadLine();
        }
    }
}
