using System;

namespace Case3
{
    class Case3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            var month = int.Parse(Console.ReadLine());

            if (month == 1 || month == 2 || month == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine($"Времени года, соответвующему месяцу \"{month}\", не существует");
            }

            Console.ReadLine();
        }
    }
}
