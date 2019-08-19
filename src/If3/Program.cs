using System;
using System.Xml.Linq;

namespace If3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число");
            var x = double.Parse(Console.ReadLine());
            if (x > 1)
            {
                x = x + 1;
            }

            if (x < -1)
            {
                x = x - 2;
            }

            if (x == 0)
            {
                x = 10;
            }

            Console.WriteLine($"Результат:{x}");
            Console.ReadLine();
        }
    }
}
