using System;
using System.Collections.Generic;

namespace NucleotideCount
{
	public static class NucleotideCount
	{
		public static IDictionary<char, int> Count(string sequence)
		{
			var nucleotides = new Dictionary<char, int>
			{
				{ 'A', 0 },
				{ 'C', 0 },
				{ 'G', 0 },
				{ 'T', 0 },
			};
			
			foreach (var letter in sequence)
			{
				if (nucleotides.ContainsKey(letter))
				{
					nucleotides[letter]++;
				}
				else
				{
					throw new ArgumentException();
				}
			}

			return nucleotides;
		}
	}
}