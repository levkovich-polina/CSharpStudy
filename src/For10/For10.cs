using System;

namespace For10
{
    class For10
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
            for (double i = 1; i <= n; i++)
            {
                sum = sum + (1/ i);
                Console.WriteLine(sum);
            }
            
            Console.ReadLine();
        }
    }
}
