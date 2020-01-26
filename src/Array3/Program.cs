using System;

namespace Array03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N ");
            var n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Число N должно быть больше 1");
                return;
            }

            Console.WriteLine("Введите целое число A ");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число D ");
            var d = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = a+i*d;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}] = {array[i]}");
            }
        }
    }
}
