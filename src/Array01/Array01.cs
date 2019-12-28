using System;

namespace Array01
{
    class Array01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N ");
            var n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                int a;
                a = 2 * i + 1;
                Console.WriteLine($"x[{i}] = {a}");
            }
        }
    }
}
