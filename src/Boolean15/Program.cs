using System;

namespace Boolean15
{
    class Program
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

            bool isAPositive = a > 0;
            bool isBPositive = b > 0;
            bool isCPositive = c > 0;

            int positiveNumberCount = 0;
            if (isAPositive)
            {
                positiveNumberCount = positiveNumberCount + 1;
            }

            if (isBPositive)
            {
                positiveNumberCount = positiveNumberCount + 1;
            }

            if (isCPositive)
            {
                positiveNumberCount = positiveNumberCount + 1;
            }

            bool onlyTwoNumbersArePositive = positiveNumberCount == 2;
            Console.WriteLine($"Являются только два числа из A,B,C положительными?- {onlyTwoNumbersArePositive}");
            Console.ReadLine();
        }
    }
}