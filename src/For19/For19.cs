using System;

namespace For19
{
    class For19
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

            double factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                Console.WriteLine($"{i}! = {factorial}");
            }

            Console.WriteLine($"Итоговый факториал числа {n} = {factorial}");
            Console.ReadLine();
        }
    }
}
