using System;

namespace Integer5
{
    class Integer5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            double a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Число A должно быть неотрицательным");
                return;
            }
            Console.WriteLine("Введите число B");
            double b = double.Parse(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine("Число B должно быть меньше числа A");
                return;
            }

            if (b == 0)
            {
                Console.WriteLine("Число B не должно быть равно 0");
                return;          
            }

            double remainder = a % b;
            Console.WriteLine($"Остаток = {remainder}");
            Console.ReadLine();
        }
    }
}
