using System;

namespace Boolean36
{
    class Boolean36
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число x1");
            var x1 = int.Parse(Console.ReadLine());
            if (x1 <= 0 || x1 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежат в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число y1");
            var y1 = int.Parse(Console.ReadLine());
            if (y1 <= 0 || y1 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежат в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число x2");
            var x2 = int.Parse(Console.ReadLine());
            if (x2 <= 0 || x2 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежат в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число y2");
            var y2 = int.Parse(Console.ReadLine());
            if (y2 <= 0 || y2 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежат в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            bool canRookMakeTurn = (x1 == x2) || (y2 == y1);
            Console.WriteLine($"Может ли ладья за один ход перейти с одного поля на другое?-{canRookMakeTurn}");
            Console.ReadLine();
        }
    }
}
