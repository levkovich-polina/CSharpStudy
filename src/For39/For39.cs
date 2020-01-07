using System;

namespace For39
{
    class For39
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число A");
            var a = int.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("Число A должно быть больше 0");
                return;
            }

            Console.WriteLine("Введите целое число B");
            var b = int.Parse(Console.ReadLine());

            if (b <= 0)
            {
                Console.WriteLine("Число B должно быть больше 0");
                return;
            }

            if (a > b)
            {
                Console.WriteLine("Число B должно быть больше числа A");
                return;
            }

            for (int i = a; i < b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"{i}");
                }
            }
    }
    }
}
