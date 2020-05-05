namespace Raindrops
{
	public static class Raindrops
	{
		/// <summary>
		/// Convert a number to a string due to special rules.
		/// </summary>
		/// <param name="number"> Number to convert. </param>
		/// <returns> String that reproduces raindrop-speak. </returns>
		public static string Convert(int number)
		{
			var result = string.Empty;

			if (number % 3 == 0)
			{
				result += "Pling";
			}

			if (number % 5 == 0)
			{
				result += "Plang";
			}

			if (number % 7 == 0)
			{
				result += "Plong";
			}

			return string.IsNullOrEmpty(result) ? number.ToString() : result;
		}
	}
}