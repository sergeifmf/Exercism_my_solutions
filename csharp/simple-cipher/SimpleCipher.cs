using System;
using System.Text;

namespace SimpleCipher
{
	public class SimpleCipher
	{
		public SimpleCipher()
		{
			var autoKey = new StringBuilder();
			var random = new Random();
			
			for (var i = 0; i < 100; i++)
			{
				var symbol = (char) ('a' + random.Next(0, 26));
				autoKey.Append(symbol);
			}

			Key = autoKey.ToString();
		}

		public SimpleCipher(string key)
		{
			Key = key;
		}
    
		public string Key { get; set; }

		public string Encode(string plaintext)
		{
			return CipherTreatment(plaintext, true);
		}

		public string Decode(string cipherText)
		{
			return CipherTreatment(cipherText, false);
		}

		private string CipherTreatment(string textForTreatment, bool isEncode)
		{
			const char startSymbol = 'a';
			const char endSymbol = '{';
			const int alphabetLength = 26;

			var resultText = new StringBuilder();
			var textForTreatmentLength = textForTreatment.Length;
			var keyLength = Key.Length;
			
			for (var i = 0; i < textForTreatmentLength; i++)
			{
				var startBias = textForTreatment[i] - startSymbol;
				var keyBias = Key[i % keyLength] - startSymbol;
				int resultCode;

				if (isEncode)
				{
					resultCode = startBias + keyBias;
				}
				else
				{
					resultCode = startBias - keyBias;
				}

				var cipheredSymbolCode = resultCode % alphabetLength;
				var biasSymbol = cipheredSymbolCode >= 0 ? startSymbol : endSymbol;

				resultText.Append((char)(biasSymbol + cipheredSymbolCode));
			}

			return resultText.ToString();
		}

	}
}