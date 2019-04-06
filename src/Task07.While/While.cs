using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07.While
{
    class While
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isNumberCorrect = false;
            while (!isNumberCorrect)
            {
                number = int.Parse(Console.ReadLine());
                isNumberCorrect = (1 <= number) && (number <= 12);
                if (!isNumberCorrect)
                {
                    Console.WriteLine("Вы ввели неправильно месяц. Пожалуйста, введите число от 1 до 12");
                }
            }

            Console.WriteLine($"Ваше число: {number}");
            Console.ReadLine();
        }
    }
}