using System;

namespace If3
{
    class If3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число");
            var x = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                x = x + 1;
            }
            else if (x < 0)
            {
                x = x - 2;
            }
            else
            {
                x = 10;
            }

            Console.WriteLine($"Результат:{x}");
            Console.ReadLine();
        }
    }
}
