using System;

namespace Boolean09
{
    class Boolean09
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число A");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = int.Parse(Console.ReadLine());

            bool isAOdd = (a % 2) == 1;
            bool isBOdd = (b % 2) == 1;
            bool isAnyNumberOdd = isBOdd || isAOdd;
        
            Console.WriteLine($"Хотя бы одно из чисел A и B нечетное?  - {isAnyNumberOdd}");
            Console.ReadLine();
        }
        
    }
}