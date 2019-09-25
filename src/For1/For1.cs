using System;

namespace For1
{
    class For1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число K");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число N");
            var count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("N должно быть больше 0");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
