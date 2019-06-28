using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer26
{
    class Integer26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер дня в году");
            var dayIndex = int.Parse(Console.ReadLine());
            if (dayIndex < 1 || dayIndex > 365)
            {
                Console.WriteLine("Номер дня должен находиться в диапазоне от 1 до 365");
                Console.ReadLine();
                return;
            }
            int dayOfWeekIndex = dayIndex % 7;
            Console.WriteLine($"Номер дня недели - {dayOfWeekIndex + 1}");
            Console.ReadLine();
        }
    }
}
