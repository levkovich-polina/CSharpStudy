using System;

namespace If24
{
    class If24
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите X");
            var x = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                double f = 2 * Math.Sin(x);
                Console.WriteLine($"F(x)={f}");
            }
            else
            {
                double f = 6 - x;
                Console.WriteLine($"F(x)={f}");
            }

            Console.ReadLine();
        }
    }
}
