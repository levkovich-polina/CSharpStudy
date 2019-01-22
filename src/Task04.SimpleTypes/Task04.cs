using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04.SimpleTypes
{
	class Task04
	{
		static void Main(string[] args)
		{
			double d1 = -2.05;
			float fl1;
			string str1;
			bool bool1 = false;
			checked
			{
				int i1 = 2147483647;
				i1 = i1 + 1;
			}
			byte byte1;
			char char1 = 'П';

			bool bool3 = true && true && true && false;
			bool bool4 = true || false || false; 


			
			bool bool2 = !bool1;
		}
	}
}
