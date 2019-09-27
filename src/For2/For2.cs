using System;

namespace For2
{
    class For2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Число A должно быть меньше числа B");
                return;
            }

            for (int i = 0; i <= b - a; i++)
            {
                Console.WriteLine(a + i);
            }

            int sum = b - a + 1;

            Console.WriteLine($"{sum} чисел");

            Console.ReadLine();
        }
    }
}
