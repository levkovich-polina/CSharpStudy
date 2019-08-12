using System;

namespace Boolean19
{
    class Boolean19
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


            bool areMutuallyOppositeNumbersExist = (a + b == 0) || (b + c == 0) || (a + c == 0);
            Console.WriteLine($"Существуют ли среди трёх чисел пара взаимно противоположных? - {areMutuallyOppositeNumbersExist}");
            Console.ReadLine();
        }
    }
}