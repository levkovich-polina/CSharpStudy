using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin12
{
    class Begin12 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите первый катет");
            int leg1 = int.Parse(Console.ReadLine());
            if (leg1 < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Катет треугольника не может быть отрицательным");
                return;
            }
            Console.WriteLine("Введите второй катет");
            int leg2 = int.Parse(Console.ReadLine());
            if (leg2 < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Катет треугольника не может быть отрицательным");
                return;
            }
            double hypotenuse = Math.Sqrt( leg1*leg1 + leg2 * leg2);
            Console.WriteLine($"С={hypotenuse}");

            double perimeter = leg1 + leg2 + hypotenuse ;
            Console.WriteLine($"P={perimeter}");

           
            Console.ReadLine();
        }
    }
}
