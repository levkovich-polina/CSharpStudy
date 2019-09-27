using System;

namespace For4
{
    class For4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цену за 1 кг");
            var price = int.Parse(Console.ReadLine());
            if (price <= 0)
            {
                Console.WriteLine("Число должно быть больше 0");
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{price * i} рублей за {i} кг");
            }

            Console.ReadLine();
        }
    }
}
