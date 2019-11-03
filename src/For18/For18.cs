using System;

namespace For18
{
    class For18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число N");
            var n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Число N должно быть больше 0");
                return;
            }

            double term = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                term = term * a * (-1);
                sum = sum + term;
                Console.WriteLine($"{i} шаг: слагаемое = {term}, промежуточная сумма = {sum}");  
            }
            Console.WriteLine($"Итоговая сумма={sum}");
            Console.ReadLine();
        }
    }
}
