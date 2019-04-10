using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin8
{
    class Begin8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            double number2 = double.Parse(Console.ReadLine());

            double arithmeticMean = (number1 + number2) / 2;
            Console.WriteLine($"A={arithmeticMean}");

            if (number1 >= 0 && number2 >= 0)
            {
                double geometricMean = Math.Sqrt(number1 * number2);
                Console.WriteLine($"G={geometricMean}");
            }
            else
            {
                Console.WriteLine("Среднее геометрическое не может быть вычислено при отричательных числах");
            }

            Console.ReadLine();
        }
    }
}