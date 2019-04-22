using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin37
{
    class Begin37
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость первого автомобиля");
            double speed = double.Parse(Console.ReadLine());
            if (speed < 0)
            {
                Console.WriteLine("Вы ввели отрицательную скорость.");
                return;
            }
            Console.WriteLine("Введите скорость второго автомобиля");
            double speed1 = double.Parse(Console.ReadLine());
            if (speed1 < 0)
            {
                Console.WriteLine("Вы ввели отрицательную скорость.");
                return;
            }
            Console.WriteLine("Введите расстояние между автомобилями");
            double distances = double.Parse(Console.ReadLine());
            if (distances < 0)
            {
                Console.WriteLine("Вы ввели отрицательное расстояние.");
                return;
            }
            Console.WriteLine("Введите время");
            double time = double.Parse(Console.ReadLine());
            if (time < 0)
            {
                Console.WriteLine("Вы ввели отрицательное время.");
                return;
            }

            double distances1 = time * (speed + speed1);
            double distances2 = Math.Abs(distances - distances1);
            Console.WriteLine($"S={distances2}");
            Console.ReadLine();

        }
    }
}
