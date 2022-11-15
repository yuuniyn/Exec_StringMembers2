using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "1100225";

			string year = value.Substring(0, 3);
			string	month = value.Substring(3, 2);
			string day = value.Substring(5, 2);

			int yearInt = Convert.ToInt32(year);
			yearInt += 1911;

			string result = yearInt + month + day;
			Console.WriteLine(result);
		}
	}
}
