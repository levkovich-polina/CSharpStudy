using System;

namespace For14
{
    class For14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N");
            var n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            int square = 0;
            for (int i = 1; i <= n; i++)
            {
                square = square + (2 * i + 1);
            }

            Console.WriteLine(square);
            Console.ReadLine();
        }
    }
}
