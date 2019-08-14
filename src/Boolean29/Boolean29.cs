using System;

namespace Boolean29
{
    class Boolean29
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число X");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число Y");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число X1");
            var x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число Y1");
            var y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число X2");
            var x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число Y2");
            var y2 = double.Parse(Console.ReadLine());

            // 1. Определить переменные xMin и xMan
            double xMin;
            double xMax;

            // 2. Вычислить xMin и xMax
            if (x1 > x2)
            {
                xMin = x2;
                xMax = x1;
            }
            else
            {
                xMin = x1;
                xMax = x2;
            }

            // 3. Определить переменные yMin и yMan
            double yMin;
            double yMax;

            // 4. Вычислить yMin и yMan
            if (y1 > y2)
            {
                yMin = y2;
                yMax = y1;
            }
            else
            {
                yMin = y1;
                yMax = y2;
            }

            // 5. Опреледить, лежит ли точка внутри прямоугольника
            bool isPointInsideRectangle = ((xMin < x) && (x < xMax)) && ((yMin < y) && (y < yMax));
            Console.WriteLine($"Лежит ли точка с координатами ({x};{y}) внутри прямоугольника?-{isPointInsideRectangle}");
            Console.ReadLine();
        }
    }
}
