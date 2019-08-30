using System;
using System.ComponentModel.Design;

namespace If23
{
    class If23
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите координату X1");
            var x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y1");
            var y1 = int.Parse(Console.ReadLine());
            ;

            Console.WriteLine("Введите координату X2");
            var x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y2");
            var y2 = int.Parse(Console.ReadLine());
            ;

            Console.WriteLine("Введите координату X3");
            var x3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y3");
            var y3 = int.Parse(Console.ReadLine());
            ;

            int x4;
            if (x1 == x2)
            {
                x4 = x3;
            }
            else if (x1 == x3)
            {
                x4 = x2;
            }
            else
            {
                x4 = x1;
            }

            int y4;
            if (y1 == y2)
            {
                y4 = y3;
            }
            else if (y1 == y3)
            {
                y4 = y2;
            }
            else
            {
                y4 = y1;
            }

            if ((x1 == x2 || x1 == x3 || x2 == x3) && (y1 == y2 || y1 == y3 || y2 == y3))
            {
                Console.WriteLine($"Координата четвертой вершины {x4};{y4}");
            }
            else
            {
                Console.WriteLine($"Неправильный прямоугольник");
            }

            Console.ReadLine();
        }
    }
}
