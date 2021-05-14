using System;

namespace TestDLL
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine(Library.Library.CheckIfPositiv(-4)); // False
			Console.WriteLine(Library.Library.CheckIfPositiv(160)); // True
			Console.WriteLine(Library.Library.CheckIfPositiv(-100000)); // False

			Console.WriteLine(Library.Library.ChackIfDivideBy5(1000)); // True
			Console.WriteLine(Library.Library.ChackIfDivideBy5(456)); // False

			Console.WriteLine(Library.Library.Sum(45, 36)); // 81
			Console.WriteLine(Library.Library.Sum(50, 500)); // 550
		}
	}
}
