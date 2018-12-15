using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.ConsoleReadAndParse
{
    class Program
    {
        static void Main(string[] args)
        {
			string str1 = Console.ReadLine();
	        double d1 = double.Parse(str1);
			Console.WriteLine(d1*2);
	        Console.ReadLine();

        }
    }
}
