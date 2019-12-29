using System;

namespace Array51
{
    class Array51
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер N ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите массив A");
            var a = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите миссив B");
            var b = int.Parse(Console.ReadLine());
            
            int[] array = new int[a];
            for ( int i = 0; i < n; ++i)
            {
                int a1;
                a1 = b;
                Console.WriteLine($"a1[{i}]={a1}");
                array[i] = a1;
            }
            for (int i = 0; i < n; ++i)
            {
                int b1;
                b1 = a;
                Console.WriteLine($"b1[{i}]={a}");
                array[i] = b1;
            }
        }
    }
}
