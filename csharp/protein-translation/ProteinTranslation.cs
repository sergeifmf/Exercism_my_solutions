using System;
using System.Collections.Generic;

namespace ProteinTranslation
{
	public static class ProteinTranslation
	{
		/// <summary>
		/// Translate RNA sequences into proteins.
		/// </summary>
		/// <param name="strand">Original RNA strand.</param>
		/// <returns>Protein sequence.</returns>
		public static string[] Proteins(string strand)
		{
			IReadOnlyDictionary<string, string> codonProtein = new Dictionary<string, string>()
			{
				{"AUG", "Methionine"},
				{"UUU", "Phenylalanine"},
				{"UUC", "Phenylalanine"},
				{"UUA", "Leucine"},
				{"UUG", "Leucine"},
				{"UCU", "Serine"},
				{"UCC", "Serine"},
				{"UCA", "Serine"},
				{"UCG", "Serine"},
				{"UAU", "Tyrosine"},
				{"UAC", "Tyrosine"},
				{"UGU", "Cysteine"},
				{"UGC", "Cysteine"},
				{"UGG", "Tryptophan"},
				{"UAA", "STOP"},
				{"UAG", "STOP"},
				{"UGA", "STOP"},
			};

			var strandLength = strand.Length;
			var proteins = new List<string>();

			if (strandLength % 3 != 0)
			{
				throw new ArgumentException();
			}

			var startLetter = 0;
			const int sequenceLength = 3;

			while (startLetter < strandLength)
			{
				var correctSequence =
					codonProtein.TryGetValue(strand.Substring(startLetter, sequenceLength), out var temp);
				
				if (!correctSequence || temp == "STOP")
				{
					break;
				}

				proteins.Add(temp);
				startLetter += sequenceLength;
			}

			return proteins.ToArray();
		}

	}
}