using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.WaterTemperature
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите объем первого стакана");
			string str1 = Console.ReadLine();
			double volume1;
			if (!double.TryParse(str1, out volume1))
			{
				Console.WriteLine("надо написать число");
				Console.ReadLine();
				return;
			}

			Console.WriteLine("Введите температуру воды в первого стакана");
			string str2 = Console.ReadLine();
			double temperature1;
            if (!double.TryParse(str2, out temperature1))
			{
				Console.WriteLine("надо написать число");
				Console.ReadLine();
				return;
			}

			Console.WriteLine("Введите объем второго стакана");
			string str3 = Console.ReadLine();
			double volume2;
			if (!double.TryParse(str3, out volume2))
			{
				Console.WriteLine("надо написать число");
				Console.ReadLine();
				return;
			}

			Console.WriteLine("Введите температуру воды во втором стакане");
			string str4 = Console.ReadLine();
			double temperature2;
			if (!double.TryParse(str4, out temperature2))
			{
				Console.WriteLine("надо написать число");
				Console.ReadLine();
				return;
			}

			double temperatureTotal = (volume1 * temperature1 + volume2 * temperature2) / (volume2 + volume1);
			Console.WriteLine("общая температура воды после смешивания {0}", temperatureTotal);
			Console.ReadLine();
		}
	}
}
