using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer21
{
    class Integer21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество секунд");
            var totalSeconds = int.Parse(Console.ReadLine());
            if (totalSeconds < 0)
            {
                Console.WriteLine("Число должно быть неотрицательным");
                Console.ReadLine();
                return;
            }

            int seconds = totalSeconds % 60;
            Console.WriteLine($"{seconds} секунд прошло с последней минуты");
            Console.ReadLine();
        }
    }
}