using System.Linq;
using System.Text;

namespace Pangram
{
	public static class Pangram
	{
		/// <summary>
		/// Determine if a sentence is a pangram. 
		/// </summary>
		/// <param name="input"> Sentence for test. </param>
		/// <returns> Is sentence a pangram. </returns>
		public static bool IsPangram(string input)
		{
			var orderInput = string.Concat(input.ToLower().Distinct());

			var countOrderInputValues = orderInput
											.Count(o => o >= 97 && o <= 122);

			return countOrderInputValues == 26;
		}
	}
}
