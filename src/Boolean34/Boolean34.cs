using System;

namespace Boolean34
{
    class Boolean34
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите число X от 1 до 8");
            var x = int.Parse(Console.ReadLine());
            if (x <= 0 || x >= 9)
            {
                Console.WriteLine("Нужно ввести число от 1 до 8");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите число Y от 1 до 8");
            var y = int.Parse(Console.ReadLine());
            if (y <= 0 || y >= 9)
            {
                Console.WriteLine("Нужно ввести число от 1 до 8");
                Console.ReadLine();
                return;
            }

            bool isFieldWhite = (x + y) % 2 == 1;
            Console.WriteLine($"Является поле белым?-{isFieldWhite}");
            Console.ReadLine();
        }
    }
}
