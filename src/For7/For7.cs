using System;
using System.Diagnostics.CodeAnalysis;

namespace For7
{
    class For7
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

            int sum = 0;
            for (int i = a; i <=b; i++)
            {
               sum= sum + i; 
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
