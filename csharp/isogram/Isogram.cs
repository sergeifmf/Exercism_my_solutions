using System.Collections.Generic;
using System.Linq;

namespace Isogram
{
	public static class Isogram
	{
		public static bool IsIsogram(string word)
		{
			var wordLength = word.Length;
			var exceptionalSymbols = new List<char>() {' ', '-',};
			var presentedSymbols = new List<char>();

			for (var i = 0; i < wordLength; i++)
			{
				word = word.ToLower();

				if (exceptionalSymbols.Any(item => item == word[i])) continue;

				if ((presentedSymbols.Count == 0) || presentedSymbols.All(item => item != word[i]))
				{
					presentedSymbols.Add(word[i]);
				}
				else
				{
					return false;
				}
			}

			return true;
		}
	}
}
