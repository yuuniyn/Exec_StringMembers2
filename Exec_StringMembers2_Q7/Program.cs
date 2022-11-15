using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("輸入手機號碼: ");
			string phone = Console.ReadLine();

			if (string.IsNullOrEmpty(phone) || phone.Length > 10)
			{
				Console.WriteLine("輸入錯誤!!");
				return;
			}

			string fisrt = phone.Substring(0, 4);
			string middle = new string('*', 4);
			string last = phone.Substring(8);
			string relust = fisrt + middle + last;

			Console.WriteLine(relust);
		}
	}
}
