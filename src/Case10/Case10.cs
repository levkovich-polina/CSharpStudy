using System;

namespace Case10
{
    class Case10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходное направление");
            Console.WriteLine("с - Север");
            Console.WriteLine("в - Восток");
            Console.WriteLine("з - Запад");
            Console.WriteLine("ю - Юг");
            var direction = char.Parse(Console.ReadLine());
            if (direction != 'с' && direction != 'ю' && direction != 'з' && direction != 'в')
            {
                Console.WriteLine("Такого направления не существует");
                return;
            }

            Console.WriteLine("Введите команду");
            Console.WriteLine("0 - продолжить движение прямо");
            Console.WriteLine("1 - поворот налево");
            Console.WriteLine("-1 - поворот направо");
            var operation = int.Parse(Console.ReadLine());
            if (operation != 0 && operation != 1 && operation != -1)
            {
                Console.WriteLine("Такой команды не существует");
                return;
            }

            if (direction == 'с')
            {
                if (operation == 0)
                {
                    Console.WriteLine("Направление на Север");
                }
                else if (operation == 1)
                {
                    Console.WriteLine("Направление на Запад");
                }
                else if (operation == -1)
                {
                    Console.WriteLine("Направление на Восток");
                }
            }
            else if (direction == 'в')
            {
                if (operation == 0)
                {
                    Console.WriteLine("Направление на Восток");
                }
                else if (operation == 1)
                {
                    Console.WriteLine("Направление на Север");
                }
                else if (operation == -1)
                {
                    Console.WriteLine("Направление на Юг");
                }
            }
            else if (direction == 'з')
            {
                if (operation == 0)
                {
                    Console.WriteLine("Направление на Запад");
                }
                else if (operation == 1)
                {
                    Console.WriteLine("Направление на Юг");
                }
                else if (operation == -1)
                {
                    Console.WriteLine("Направление на Север");
                }
            }
            else if (direction == 'ю')
            {
                if (operation == 0)
                {
                    Console.WriteLine("Направление на Юг");
                }
                else if (operation == 1)
                {
                    Console.WriteLine("Направление на Восток");
                }
                else if (operation == -1)
                {
                    Console.WriteLine("Направление на Запад");
                }
            }

            Console.ReadLine();
        }
    }
}
