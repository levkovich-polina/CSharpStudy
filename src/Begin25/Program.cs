using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Begin25
{
    class Begin25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            double x = double.Parse(Console.ReadLine());

            double Y = 3*x*x*x*x*x*x - 6*x*x -7 ;
            Console.WriteLine($"y={Y}");
            Console.ReadLine();

        }
    }
}
