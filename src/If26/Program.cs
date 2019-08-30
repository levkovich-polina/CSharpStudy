using System;
using System.ComponentModel.Design;

namespace If26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите X");
            var x = double.Parse(Console.ReadLine());

            if (x <= 0)
            {
                double x1;
                x1 = -x;
                Console.WriteLine($"F(x)={x1}");
            }
            else if (0 < x && x < 2)
            {
                double x2;
                x2 = x * x;
                Console.WriteLine($"F(x)={x2}");
            }
            else
            {
                Console.WriteLine($"F(x)=4");
            }

            Console.ReadLine();
        }
    }
}
