using System;

namespace Grains
{
	public static class Grains
	{
		public static ulong Square(int n)
		{
			if (n <= 0 || n > 64)
			{
				throw new ArgumentOutOfRangeException();
			}

			return (ulong)Math.Pow(2, n - 1);
		}

		public static ulong Total()
		{
			const int max = 64;
			var result = 0UL;

			for (var i = 1; i <= max; i++)
			{
				result += Square(i);
			}
			
			return result;
		}
	}
}