using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfMultiples
{
	public static class SumOfMultiples
	{
		/// <summary>
		/// Given a number, find the sum of all the unique multiples of particular numbers
		/// up to but not including that number.
		/// </summary>
		/// <param name="multiples"> List of Unique multiples. </param>
		/// <param name="max"> Given number. </param>
		/// <returns></returns>
		public static int Sum(IEnumerable<int> multiples, int max)
		{
			if (multiples == null || multiples == Array.Empty<int>()) return 0;

			var minValue = multiples.Min();

			if (minValue > max) return 0;

			var numbers = new List<int>();

			for (var i = minValue; i < max; i++)
			{
				numbers.Add(i);
			}

			int result;

			try
			{
				result = numbers
					.Where(n => multiples.Any(m => m > 0 && n % m == 0))
					.Sum();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				result = multiples.Max();
			}
			

			return result;
		}
	}
}