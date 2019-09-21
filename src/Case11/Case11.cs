using System;
using System.ComponentModel.Design;

namespace Case11
{
    class Case11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходное направление");
            Console.WriteLine("c - Север");
            Console.WriteLine("в - Восток");
            Console.WriteLine("з - Запад");
            Console.WriteLine("ю - Юг");
            var direction = char.Parse(Console.ReadLine());
            int way;
            if (direction == 'с')
            {
                way = 0;
            }
            else if (direction == 'в')
            {
                way = 1;
            }
            else if (direction == 'з')
            {
                way = 3;
            }
            else if (direction == 'ю')
            {
                way = 2;
            }
            else
            {
                Console.WriteLine($"Направления '{direction}' не существует");
                return;
            }

            Console.WriteLine("Введите команду");
            Console.WriteLine("1 - поворот налево");
            Console.WriteLine("-1 - поворот направо");
            Console.WriteLine("2 - поворот на 180 градусов");
            var operation = int.Parse(Console.ReadLine());

            int command;
            if (operation == 1)
            {
                command = -1;
            }
            else if (operation == -1)
            {
                command = 1;
            }
            else if (operation == 2)
            {
                command = 2;
            }
            else
            {
                Console.WriteLine($"Команда '{operation}' не является допустимой");
                return;
            }

            int finalWay = (way + command) % 4;
            if (finalWay == 0)
            {
                Console.WriteLine("Орентирован на Север");
            }
            else if (finalWay == 1)
            {
                Console.WriteLine("Орентирован на Восток");
            }
            else if (finalWay == 2)
            {
                Console.WriteLine("Орентирован на Юг");
            }
            else if (finalWay == 3)
            {
                Console.WriteLine("Орентирован на Запад");
            }

            Console.ReadLine();
        }
    }
}
