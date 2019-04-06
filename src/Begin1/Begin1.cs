using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin1
{
    class Begin1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Следует ввести положительное число");
                return;
            }
            Console.WriteLine($"P={number*4}");
            Console.ReadLine();
        }
    }
}
