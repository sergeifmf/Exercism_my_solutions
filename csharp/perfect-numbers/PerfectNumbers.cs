using System.Linq;

namespace PerfectNumbers
{
	public static class PerfectNumbers
	{
		/// <summary>
		/// Nicomachus' (60 - 120 CE) classification scheme for natural numbers.
		/// </summary>
		public enum Classification
		{
			Perfect = 0,
			Abundant = 1,
			Deficient = 2
		}

		/// <summary>
		/// Determine if a number is perfect, abundant, or deficient
		/// based on Nicomachus' (60 - 120 CE) classification scheme for natural numbers.
		/// </summary>
		/// <param name="number">Number for determination.</param>
		/// <returns>Perfect, abundant, or deficient.</returns>
		public static Classification Classify(int number)
		{
			var numberRange = Enumerable.Range(1, number - 1);

			var aliquotSum = numberRange.Where(item => number % item == 0).Sum();

			if (number == aliquotSum)
			{
				return Classification.Perfect;
			}
			else
			{
				if (number > aliquotSum)
				{
					return Classification.Deficient;
				}
			}

			return Classification.Abundant;
		}
	}
}