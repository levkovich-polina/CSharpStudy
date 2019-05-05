using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer4
{
    class Integer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Число A должно быть неотрицательным");
                return;
            }
            Console.WriteLine("Введите число B");
            int b = int.Parse(Console.ReadLine());
            if (b > a)
            {
                Console.WriteLine("Число B должно быть меньше числа A");
                return;
            }

            int ab = a / b;
            Console.WriteLine($"{ab} целых отрезков");
            Console.ReadLine();
        }
    }
}
