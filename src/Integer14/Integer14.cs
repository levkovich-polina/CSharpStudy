using System;

namespace Integer14
{
    class Integer14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзнчное число");
            var number = int.Parse(Console.ReadLine());
            if (number < 100 || number >= 1000)
            {
                Console.WriteLine("Число должно быть трёхзначным");
                Console.ReadLine();
                return;
            }

            int hundreds = number / 100;
            int tens = number / 10 % 10;
            int units = number % 10;
            int sum = (units * 100) + (hundreds * 10) + tens;
            Console.WriteLine($"{sum}");
            Console.ReadLine();
        }
    }
}