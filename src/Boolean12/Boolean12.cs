using System;

namespace Boolean12
{
    class Boolean12
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число A");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите число C");
            var c = int.Parse(Console.ReadLine());

            bool isAOdd = a > 0;
            bool isBOdd = b > 0;
            bool isCOdd = c > 0;
            bool areAllNumbersPositive = isAOdd && isBOdd && isCOdd;

            Console.WriteLine($"Является каждое из чисел положительным?  - {areAllNumbersPositive}");
            Console.ReadLine();
        }
    }
}