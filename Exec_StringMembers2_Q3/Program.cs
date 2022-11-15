using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "aLLeN kUO";
			string temp = value.ToLower();

			string FirstName = temp.Substring(0, 1);
			string LastName = temp.Substring(6, 1);

			string result = FirstName.ToUpper() + temp.Substring(1, 5)
				+ LastName.ToUpper() + temp.Substring(7);
			Console.WriteLine(result) ;
		}
	}
}
