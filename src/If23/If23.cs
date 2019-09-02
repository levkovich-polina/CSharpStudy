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

            Console.WriteLine("Введите координату X2");
            var x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y2");
            var y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату X3");
            var x3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y3");
            var y3 = int.Parse(Console.ReadLine());

            bool isRectangleExist = true;

            int x4 = 0;
            if (x1 == x2)
            {
                x4 = x3;
            }
            else if (x1 == x3)
            {
                x4 = x2;
            }
            else if (x2 == x3)
            {
                x4 = x1;
            }
            else
            {
                isRectangleExist = false;
            }

            int y4 = 0;
            if (isRectangleExist)
            {
                if (y1 == y2)
                {
                    y4 = y3;
                }
                else if (y1 == y3)
                {
                    y4 = y2;
                }
                else if (y2 == y3)
                {
                    y4 = y1;
                }
                else
                {
                    isRectangleExist = false;
                }
            }

            if (isRectangleExist)
            {
                Console.WriteLine($"Координаты 4oй вершины равны ({x4};{y4})");
            }
            else
            {
                Console.WriteLine($"Не существует прямоугольника с вершинами ({x1};{y1}), ({x2};{y2}) и ({x3};{y3}), стороны которого параллельны осям координат.");
            }

            Console.ReadLine();
        }
    }
}
