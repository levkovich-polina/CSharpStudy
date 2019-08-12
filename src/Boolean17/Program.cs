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
            bool isNumberOdd = ((a % 2) == 1);
            bool isNumberThreeDigit = (a > 99) && (a < 1000);
            bool isNumberThreeDigitAndOdd = (isNumberThreeDigit && isNumberOdd);
            Console.WriteLine($"Является число нечетным и трёхзначным?-{isNumberThreeDigitAndOdd}");
            Console.ReadLine();
        }
    }
}