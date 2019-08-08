using System;

namespace Boolean14
{
    class Boolean14
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

            bool isOnlyAPositive = (a > 0) && (b < 0) && (c < 0);
            bool isOnlyBPositive = (a < 0) && (b > 0) && (c < 0);
            bool isOnlyCPositive = (a < 0) && (b < 0) && (c > 0);
            bool isOnlyOneNumberPositive = isOnlyAPositive || isOnlyBPositive || isOnlyCPositive;

            Console.WriteLine($"Является только одно из чисел A,B,C положительным? - {isOnlyOneNumberPositive}");
            Console.ReadLine();
        }
    }
}