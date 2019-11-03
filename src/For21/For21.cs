using System;
using System.Diagnostics.CodeAnalysis;

namespace For21
{
    class For21
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

            int factorial = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                double term = 1.0 / factorial;
                sum = sum + term;
                Console.WriteLine($"{i} шаг: слагаемое = {term}; промежуточный результат = {sum}");
            }

            Console.WriteLine($"Итоговый результат = {sum}");
            Console.ReadLine();
        }
    }
}
