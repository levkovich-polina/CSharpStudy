using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer28
{
    class Integer28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер дня в году");
            var dayIndex1 = int.Parse(Console.ReadLine());
            if (dayIndex1 < 1 || dayIndex1 > 365)
            {
                Console.WriteLine("Номер дня должен находиться в диапазоне от 1 до 365");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Введите номер дня недели,которое было 1 января");
            var dayIndex2 = int.Parse(Console.ReadLine());
            if (dayIndex2 < 1 || dayIndex2 > 365)
            {
                Console.WriteLine("Номер дня должен находиться в диапазоне от 1 до 7");
                Console.ReadLine();
                return;
            }

            int dayOfTheWeek = ((dayIndex1 + dayIndex2 -2) % 7)+1;
            Console.WriteLine($"Номер дня недели - {dayOfTheWeek}");
            Console.ReadLine();


        }
    }
}
