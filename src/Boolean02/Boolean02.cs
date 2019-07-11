using System;

namespace Boolean02
{
    class Boolean02
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число");
            var number = int.Parse(Console.ReadLine());

            bool isNumberOdd = ((number % 2) == 1);
            Console.WriteLine($"Число {number} является нечетным? - {isNumberOdd}");
            Console.ReadLine();
        }
    }
}