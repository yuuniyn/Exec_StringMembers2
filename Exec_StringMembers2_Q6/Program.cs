using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string result = "Allen";

			Console.Write("請輸入名字 ");
			string input = Console.ReadLine();

			if (result == input)
				Console.WriteLine("正確");
			else
				Console.WriteLine("錯誤");
		}
	}
}
