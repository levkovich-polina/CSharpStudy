using System;

namespace For30
{
    class For30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N");
            var n = int.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Число N должно быть больше 1");
                return;
            }

            Console.WriteLine("Введите целое число A");
            var a = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Введите целое число B");
            var b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Число A должно быть меньше числа B");
                return;
            }

            int h = (b - a) / n;
            Console.WriteLine($"Длина отрезков равна={h}");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"F{a+i*h}={1-Math.Sin(a + i * h)}");
            }
        }
    }

}
