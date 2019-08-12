using System;

namespace Boolean21
{
    class Boolean21
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите трёхзначное число");
            var number = int.Parse(Console.ReadLine());
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Нужно ввести трёхзначное число");
                Console.ReadLine();
                return;
            }
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;
            bool doDigitsFormIncreasingSequence = (hundreds < tens) && (tens < units);
            Console.WriteLine($"Образуют ли цифры возрастающую последовательность?-{doDigitsFormIncreasingSequence}");
            Console.ReadLine();

        }
    }
}