using System;

namespace For5
{
    class For5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цену за 1 кг");
            var price = double.Parse(Console.ReadLine());
            if (price <= 0)
            {
                Console.WriteLine("Число должно быть больше 0");
                return;
            }

            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{price*(i/10)} рублей за {i/10} кг");
            }

            Console.ReadLine();
        }
    }
}
