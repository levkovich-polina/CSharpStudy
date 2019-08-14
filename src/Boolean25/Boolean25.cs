using System;

namespace Boolean25
{
    class Boolean25
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число X");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число Y");
            var y = int.Parse(Console.ReadLine());

            bool isPointInSecondCoordinateQuarter = (x < 0) && (y > 0);
            Console.WriteLine($"Точка с координатами (x,y) лежит во второй координатной четверти?-{isPointInSecondCoordinateQuarter}");
            Console.ReadLine();
        }
    }
}