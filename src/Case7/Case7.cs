using System;
using System.ComponentModel.Design;

namespace Case7
{
    class Case7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите единицы массы");
            Console.WriteLine("1 - килограмм");
            Console.WriteLine("2 - миллиграмм");
            Console.WriteLine("3 - грамм");
            Console.WriteLine("4 - тона");
            Console.WriteLine("5 - центнер");
            var units = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите массу тела");
            var weight = double.Parse(Console.ReadLine());

            string format = "0.###########";
            if (units == 1)
            {
                double transformedWeight = weight;
                Console.WriteLine($"{transformedWeight.ToString(format)} килограмм");
            }
            else if (units == 2)
            {
                double transformedWeight = (weight / 1000000);
                Console.WriteLine($"{transformedWeight.ToString(format)} килограмм");
            }
            else if (units == 3)
            {
                double transformedWeight = weight / 1000;
                Console.WriteLine($"{transformedWeight.ToString(format)} килограмм");
            }
            else if (units == 4)
            {
                double transformedWeight = weight * 1000;
                Console.WriteLine($"{transformedWeight.ToString(format)} килограмм");
            }
            else if (units == 5)
            {
                double transformedWeight = weight * 100;
                Console.WriteLine($"{transformedWeight.ToString(format)} килограмм");
            }
            else
            {
                Console.WriteLine("Неверный номер единицы массы");
            }

            Console.ReadLine();
        }
    }
}
