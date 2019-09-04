using System;
using System.ComponentModel.Design;

namespace Case2
{
    class Case2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите оценку");
            var mark = int.Parse(Console.ReadLine());

            if (mark == 1)
            {
                Console.WriteLine("Плохо");
            }
            else if (mark==2)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            else if (mark==3)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (mark == 4)
            {
                Console.WriteLine("Хорошо");
            }
            else if (mark == 5)
            {
                Console.WriteLine("Отлично");
            }
            else
            {
                Console.WriteLine($"Оценка, соответсвующая числу \"{mark}\", не существует");
            }

            Console.ReadLine();
        }
    }
}
