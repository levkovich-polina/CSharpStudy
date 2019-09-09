using System;

namespace Case5
{
    class Case5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер арифметического действия");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            var operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число B");
            var b = double.Parse(Console.ReadLine());
            if (b == 0 && operation == 4)
            {
                Console.WriteLine("Программа не позволяет делить на ноль");
                return;
            }

            double c = 0;
            if (operation == 1)
            {
                c = a + b;
            }
            else if (operation == 2)
            {
                c = a - b;
            }
            else if (operation == 3)
            {
                c = a * b;
            }
            else if (operation == 4)
            {
                c = a / b;
            }
            else
            {
                Console.WriteLine($"Действия с номером {operation} не существует");
                return;
            }

            Console.WriteLine($"Результат: {c}");
            Console.ReadLine();
        }
    }
}
