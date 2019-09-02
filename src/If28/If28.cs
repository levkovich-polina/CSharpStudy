using System;

namespace If28
{
    class If28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года");
            var year = int.Parse(Console.ReadLine());
            if (year <= 0)
            {
                Console.WriteLine("Число должно быть положительным");
                Console.ReadLine();
                return;
            }

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Это високосный год, в нем 366 дней");
            }
            else
            {
                Console.WriteLine("Это обычный год, в нем 365 дней");
            }

            Console.ReadLine();
        }
    }
}
