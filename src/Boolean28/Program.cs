using System;

namespace Boolean28
{
    class Boolean28
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число X");
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число Y");
            var y = int.Parse(Console.ReadLine());

            bool pointWithCoordinateXYLiesinTheFirstOrThirdCoordinateQuarter = ((x < 0) && (y < 0))||((x>0)&&(y>0));
            Console.WriteLine($"Точка с координатами (x,y) лежит в первой или третьей координатной четверти?-{pointWithCoordinateXYLiesinTheFirstOrThirdCoordinateQuarter}");
            Console.ReadLine();

        }
    }
}