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
            double speed1 = double.Parse(Console.ReadLine());
            if (speed1 < 0)
            {
                Console.WriteLine("Вы ввели отрицательную скорость Скорость автомобиля не должна быть отрицательной.");
                return;
            }

            Console.WriteLine("Введите скорость второго автомобиля");
            double speed2 = double.Parse(Console.ReadLine());
            if (speed2 < 0)
            {
                Console.WriteLine("Вы ввели отрицательную скорость. Скорость автомобиля не должна быть отрицательной");
                return;
            }

            Console.WriteLine("Введите первоначальное расстояние между автомобилями");
            double startDistance = double.Parse(Console.ReadLine());
            if (startDistance < 0)
            {
                Console.WriteLine("Вы ввели отрицательное расстояние. Первоначальное расстояние не должно быть отрицательным");
                return;
            }

            Console.WriteLine("Введите время");
            double time = double.Parse(Console.ReadLine());
            if (time < 0)
            {
                Console.WriteLine("Вы ввели отрицательное время. Время не должно быть отрицательным");
                return;
            }

            double distance1 = time * speed1;
            double distance2 = time * speed2;
            double sumCarDistance = distance1 + distance2;
            double finalDistance = Math.Abs(startDistance - sumCarDistance);
            Console.WriteLine($"Final distance={finalDistance}");
            Console.ReadLine();
        }
    }
}