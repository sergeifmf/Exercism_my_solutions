using System;
using System.Linq;

namespace DifferenceOfSquares
{
	public static class DifferenceOfSquares
	{
		public static int CalculateSquareOfSum(int max)
		{
			var result = Enumerable.Range(1, max).Aggregate(0, (total, next) => total + next);

			return (int)Math.Pow(result, 2);
		}

		public static int CalculateSumOfSquares(int max)
		{
			return Enumerable.Range(1, max).Aggregate(0, (total, next) => total + (int)Math.Pow(next, 2));
		}

		public static int CalculateDifferenceOfSquares(int max)
		{
			return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
		}

	}
}