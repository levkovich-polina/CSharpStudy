using System;

namespace If16
{
    class If16
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число C");
            var c = double.Parse(Console.ReadLine());
            if (a < b && b < c)
            {
                a = a * 2;
                b = b * 2;
                c = c * 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }

            Console.WriteLine($"A={a}");
            Console.WriteLine($"B={b}");
            Console.WriteLine($"C={c}");
            Console.ReadLine();
        }
    }
}
