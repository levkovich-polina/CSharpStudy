using System;

namespace Begin13
{
    class Begin13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус первой окружности");
            int radius1 = int.Parse(Console.ReadLine());
            if (radius1 < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Радиус не может быть отрицательным");
                return;
            }

            Console.WriteLine("Введите радиус второй окружности");
            int radius2 = int.Parse(Console.ReadLine());
            if (radius2 < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число. Радиус не может быть отрицательным");
                return;
            }

            if (radius2 > radius1)
            {
                Console.WriteLine(
                    "Вы ввели радиус второй окружности больше чем радиус первой окружности. Радиус второй окружности должен быть меньше радиуса первой окружности");
                return;
            }

            double p = 3.14;
            double s1 = p * radius1 * radius1;
            Console.WriteLine($"s1={s1}");

            double s2 = p * radius2 * radius2;
            Console.WriteLine($"s2={s2}");

            double s3 = s1 - s2;
            Console.WriteLine($"S3={s3}");


            Console.ReadLine();
        }
    }
}