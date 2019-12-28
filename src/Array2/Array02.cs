using System;

namespace Array2
{
    class Array02

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N ");
            var n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i}й элемент массивва");
                var a = int.Parse(Console.ReadLine());
                array[i] = a;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x[{i}] = {array[i]}");
            }
        }
    }
}
