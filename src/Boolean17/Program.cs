using System;

namespace Boolean17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите положительное число");
            var a = int.Parse(Console.ReadLine());
            bool theNumberIsThreeDigitAndPositive = ((a > 99) && ((a % 2 )==0));
            Console.WriteLine($"Является число нечетным и положительным?-{theNumberIsThreeDigitAndPositive}");
            Console.ReadLine();

        }
    }
}