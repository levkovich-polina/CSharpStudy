using System;

namespace Integer18
{
    class Integer18
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите число больше 999");
            var number = int.Parse(Console.ReadLine());
            if (number < 1000)
            {
                Console.WriteLine("Число должно быть больше 999");
                Console.ReadLine();
                return;
            }

            int rest = number % 10000;
            int thousands = rest / 1000;
            Console.WriteLine($"Цифра, соответсвующая разряду тысяч, - {thousands}");
            Console.ReadLine();

        }
    }
}