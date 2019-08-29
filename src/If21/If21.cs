using System;

namespace If21
{
    class If21
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите координату X");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y");
            var y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine($"0");
                Console.ReadLine();
            }
            else if (y == 0)
            {
                Console.WriteLine($"1");
                Console.ReadLine();
            }
            else if (x == 0)
            {
                Console.WriteLine($"2");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"3");
                Console.ReadLine();
            }
        }
    }
}
