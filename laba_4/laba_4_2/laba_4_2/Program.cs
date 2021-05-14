using System;

namespace Library
{
	public static class Library
	{
		public static bool CheckIfPositiv(int x)
		{
				if (x>0)
					return true;

			return false;
		}

		public static bool ChackIfDivideBy5(int x)
		{
			if (x%5!=0)
				return false;

			return true;
		}

		public static int Sum(int x, int y)
		{
			 x+= y;
			return x;
		}

	}
}