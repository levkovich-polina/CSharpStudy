using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer1
{
    class Integer1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в сантиметрах");
            int l = int.Parse(Console.ReadLine());
            if (l < 0)
            {
                Console.WriteLine("Расстояние не может быть отрицательным");
                return;
            }

            int lenght = l / 100;
            Console.WriteLine($"{l} сантиметров = {lenght} метров");
            Console.ReadLine();

        }
    }
}
