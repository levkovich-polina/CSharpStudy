using System;

namespace Boolean6
{
    class Boolean6
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

            bool isInequalityTrue = ((a < b) && (b < c));
            Console.WriteLine($"Справедливо двойное неравенство A<B<C? - {isInequalityTrue}");
            Console.ReadLine();
        }
    }
}