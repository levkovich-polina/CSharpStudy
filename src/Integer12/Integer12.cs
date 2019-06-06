using System;

namespace Integer12
{
    static class Integer12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзнчное число");
            int number;
            number = int.Parse(Console.ReadLine());
            if (number < 100 || number >= 1000)
            {
                Console.WriteLine("Число должно быть трёхзначным");
                Console.ReadLine();
                return;
            }

            int hundreds = number / 100;
            int tens = number / 10 % 10;
            int units = number % 10;
            int sum = (units * 100) + (tens * 10) + hundreds;
            Console.WriteLine($"{sum} число при прочтение справа налево");
            Console.ReadLine();
        }
    }
}