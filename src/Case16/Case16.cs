using System;

namespace Case16
{
    class Case16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст от 20 до 69 лет");
            var age = int.Parse(Console.ReadLine());
            if (age < 20 || age > 69)
            {
                Console.WriteLine("Возраст должен быть от 20 до 69 лет");
                return;
            }

            int tens = age / 10;
            if (tens == 2)
            {
                Console.Write("Двадцать");
            }
            else if (tens == 3)
            {
                Console.Write("Тридцать");
            }
            else if (tens == 4)
            {
                Console.Write("Сорок");
            }
            else if (tens == 5)
            {
                Console.Write("Пятьдесят");
            }
            else if (tens == 6)
            {
                Console.Write("Шестьдесят");
            }

            Console.Write(" ");

            int units = age % 10;
            if (units == 1)
            {
                Console.Write("один");
            }
            else if (units == 2)
            {
                Console.Write("два");
            }
            else if (units == 3)
            {
                Console.Write("три");
            }
            else if (units == 4)
            {
                Console.Write("четыре");
            }
            else if (units == 5)
            {
                Console.Write("пять");
            }
            else if (units == 6)
            {
                Console.Write("шесть");
            }
            else if (units == 7)
            {
                Console.Write("семь");
            }
            else if (units == 8)
            {
                Console.Write("восемь");
            }
            else if (units == 9)
            {
                Console.Write("девять");
            }

            Console.Write(" ");

            if (units == 1)
            {
                Console.Write("год");
            }
            else if (units >= 2 && units <= 4)
            {
                Console.Write("года");
            }
            else
            {
                Console.Write("лет");
            }

            Console.ReadLine();
        }
    }
}
