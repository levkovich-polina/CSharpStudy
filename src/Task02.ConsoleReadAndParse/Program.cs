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
			double d1;
			bool isParseSuccessful = double.TryParse(str1, out d1);
			if (isParseSuccessful)
			{
				Console.WriteLine(d1 * 2);
			}
			else
			{
				Console.WriteLine("надо написать число");
			}

			Console.ReadLine();
		}
	}
}
