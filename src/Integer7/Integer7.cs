using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer7
{
    class Integer7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите двухзначное число");
            int number;
            number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            if (number < 10 || number >= 100 )
            {
                Console.WriteLine("Число должно быть двухзначным");
                Console.ReadLine();
                return;
            }
            
            int tens = Math.Abs(number / 10);
            int units = Math.Abs(number % 10);
            int sum = tens + units;
            int multiplication = tens * units;
            Console.WriteLine($"{sum} сумма двух цирф");
            Console.WriteLine($"{multiplication} произведение двух цифр");
            Console.ReadLine();
        }
    }
}