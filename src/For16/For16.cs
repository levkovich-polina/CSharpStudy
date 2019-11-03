using System;

namespace For16
{
    class For16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число N");
            var n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            double number = 1;
            for (int i = 1; i <= n; i++)
            {
                number = number * a;
                Console.WriteLine($"Число {a} в степени {i} = {number}");
            }
            
            Console.ReadLine();
        }
    }
}
