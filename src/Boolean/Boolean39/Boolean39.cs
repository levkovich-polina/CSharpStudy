using System;

namespace Boolean39
{
    class Boolean39
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число x1");
            var x1 = int.Parse(Console.ReadLine());
            if (x1 <= 0 || x1 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежать в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число y1");
            var y1 = int.Parse(Console.ReadLine());
            if (y1 <= 0 || y1 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежать в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число x2");
            var x2 = int.Parse(Console.ReadLine());
            if (x2 <= 0 || x2 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежать в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число y2");
            var y2 = int.Parse(Console.ReadLine());
            if (y2 <= 0 || y2 >= 9)
            {
                Console.WriteLine("Координата поля шахматной доски должна лежать в интервале от 1 до 8");
                Console.ReadLine();
                return;
            }

            int deltaX = x2 - x1;
            int deltaY = y2 - y1;
            int absDeltaX = Math.Abs(deltaX);
            int absDeltaY = Math.Abs(deltaY);
            bool canQueenMove = ((absDeltaX == absDeltaY || (deltaX == 0 && 0 < absDeltaY)) || (deltaY == 0 && 0 < absDeltaX)) && (absDeltaY > 0 && absDeltaX > 0);
            Console.WriteLine($"Может ли ферзь переместиться с поля ({x1};{y1}) на поле ({x2};{y2})?-{canQueenMove}");
            Console.ReadLine();
        }
    }
}
