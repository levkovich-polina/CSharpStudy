using System;

namespace If10
{
    class If10
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число A");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = int.Parse(Console.ReadLine());

            if (a != b)
            {
                int sum = a + b;
                a = sum;
                b = sum;
            }
            else
            {
                a = 0;
                b = 0;
            }

            Console.WriteLine($"A={a}");
            Console.WriteLine($"B={b}");
            Console.ReadLine();
        }
    }
}
