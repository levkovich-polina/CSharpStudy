using System;

namespace Boolean22
{
    class Boolean22
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
            bool doDigitsFormDecreasingSequence = (hundreds > tens) && (tens > units);
            bool doDigitsFormIncreasingOrDecreasingSequence = doDigitsFormDecreasingSequence || doDigitsFormIncreasingSequence;
            Console.WriteLine($"Образуют ли цифры возрастающую или убывающую последовательность?-{doDigitsFormIncreasingOrDecreasingSequence}");
            Console.ReadLine();

        }
    }
}