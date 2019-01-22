using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Передаю всем роботам привет!");
            Console.ReadLine();

	        for (int i = 0; i < 5; i++)
	        {
		        Console.WriteLine("Робот android #{0} приветствует вас!", i + 1);
	        }
            Console.ReadLine();
        }
    }
}
