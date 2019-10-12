using System;

namespace For11
{
    class For11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            var n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                sum = sum +(n+i)*(n + i);
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
