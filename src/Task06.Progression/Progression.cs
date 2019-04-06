using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06.Progression
{
    public class Progression
    {
        public static void Main()
        {
            Console.WriteLine("напишите исходное число");
            string str1 = Console.ReadLine();
            int number1;
            if (!int.TryParse(str1, out number1))
            {
                Console.WriteLine("надо написать число");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("введите шаг");
            string str2 = Console.ReadLine();
            int step;
            if (!int.TryParse(str2, out step))
            {
                Console.WriteLine("надо написать число");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("напишите количество чисел");
            string str3 = Console.ReadLine();
            int count;
            if (!int.TryParse(str3, out count))
            {
                Console.WriteLine("надо написать число");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(step*i + number1);
            }


            Console.ReadLine();
        }
    }
}