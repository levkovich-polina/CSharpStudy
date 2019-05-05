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
            int lengthInCentimeters = int.Parse(Console.ReadLine());
            if (lengthInCentimeters < 0)
            {
                Console.WriteLine("Расстояние не может быть отрицательным");
                return;
            }

            int lengthInMeters = lengthInCentimeters / 100;
            Console.WriteLine($"{lengthInCentimeters} сантиметров = {lengthInMeters} метров");
            Console.ReadLine();

        }
    }
}
