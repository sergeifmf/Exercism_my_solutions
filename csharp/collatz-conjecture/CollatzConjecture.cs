using System;

namespace CollatzConjecture
{
	public static class CollatzConjecture
	{
		/// <summary>
		/// Given a number, return the number of steps in the calculation of the Collatz Conjecture.
		/// </summary>
		/// <param name="number"> Given a number </param>
		/// <returns> Number of steps </returns>
		public static int Steps(int number)
		{
			if (number < 1)
			{
				throw new ArgumentException();
			}

			var counter = 0;

			while (number > 1)
			{
				number = number % 2 == 0 ? number / 2 : number * 3 + 1;
				counter++;
			}

			return counter;
		}
	}
}