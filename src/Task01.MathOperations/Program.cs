using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.MathOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			double d1 = 7;
			double d2 = 6;

			Console.WriteLine("+ {0}", d1 + d2);
			Console.WriteLine("- {0}", d1 - d2);
			Console.WriteLine("* {0}", d1 * d2);
			Console.WriteLine("/ {0}", d1 / d2);

			int i1 = 9;
			double d3 = 0.1 + 0.2;
			double d4 = 0.3;
			double epsilon = 0.000001;
			Console.WriteLine(Math.Abs(d3 - d4) < epsilon);
			Console.ReadLine();
		}
	}
}
