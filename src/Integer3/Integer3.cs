using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer3
{
    class Integer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер файла в байтах");
            int b = int.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Размер файла не может быть отрицательным");
                return;
            }

            int kB = b / 1024;
            Console.WriteLine($"{b} байта= {kB} килобайт");
            Console.ReadLine();

        }
    }
}
