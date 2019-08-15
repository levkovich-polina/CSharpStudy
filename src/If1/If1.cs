using System;

namespace If1
{
    class If1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Выберете режим работы программы:");
            Console.WriteLine("1. Ввести данные вручную");
            Console.WriteLine("2. Тестирование");
            var key = Console.ReadKey();
            Console.WriteLine();
            if (key.KeyChar == '1')
            {
                ManualMode();
            }
            else if (key.KeyChar == '2')
            {
                TestMode();
            }
            else
            {
                Console.WriteLine("Нужно выбрать один из режимов: 1 или 2");
            }

            Console.ReadLine();
        }

        private static void ManualMode()
        {
            Console.WriteLine("Введите число");
            var number = int.Parse(Console.ReadLine());

            int result = F(number);

            Console.WriteLine($"Результат: {result}");
        }

        private static void TestMode()
        {
            Console.WriteLine($"Тест 1: {F(5) == 6}");
            Console.WriteLine($"Тест 2: {F(7) == 8}");
            Console.WriteLine($"Тест 3: {F(-1) == -1}");
            Console.WriteLine($"Тест 4: {F(0) == 0}");
        }

        private static int F(int x)
        {
            if (x > 0)
            {
                x = x + 1;
            }

            return x;
        }
    }
}
