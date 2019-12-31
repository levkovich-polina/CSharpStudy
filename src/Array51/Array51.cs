using System;

namespace Array51
{
    class Array51
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер N ");
            var n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array1[i] = random.Next(0, 100);
            }

            for (int i = 0; i < n; i++)
            {
                array2[i] = random.Next(100, 200);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}]={array1[i]}; b[{i}]={array2[i]}");
            }

            for (int i = 0; i < n; i++)
            {
                int temp = array1[i];
                array1[i] = array2[i];
                array2[i] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"a[{i}]={array1[i]}; b[{i}]={array2[i]}");
            }
        }
    }
}
