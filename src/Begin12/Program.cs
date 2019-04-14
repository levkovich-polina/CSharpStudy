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
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Катет треугольника не может быть отрицательной");
                return;
            }
            Console.WriteLine("Введите второй катет");
            int count = int.Parse(Console.ReadLine());
            if (count < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Катет треугольника не может быть отрицательной");
                return;
            }
            double hypotenuse = Math.Sqrt( number*number + count * count);
            Console.WriteLine($"С={hypotenuse}");

            double perimeter = number + count + hypotenuse ;
            Console.WriteLine($"P={perimeter}");

           
            Console.ReadLine();
        }
    }
}
