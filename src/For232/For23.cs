using System;

namespace For232
{
    class For23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N");
            var n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            Console.WriteLine("Введите  число X");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sin={((-1) * x * x) / ((2 * n + 2) * (2 * n + 3))}");
        }
    }
}
