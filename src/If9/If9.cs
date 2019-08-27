using System;

namespace If9
{
    class If9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = double.Parse(Console.ReadLine());

            double c;

            if (a > b)
            {
                c = b;
                b = a;
                a = c;
            }

            Console.WriteLine($"Меньшее значение - {a};");
            Console.WriteLine($"Большее значение - {b}");
            Console.ReadLine();
        }
    }
}
