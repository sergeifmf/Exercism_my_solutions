using System.Text;

namespace Acronym
{
	public static class Acronym
	{
		public static string Abbreviate(string phrase)
		{
			var result = new StringBuilder();
			var wordStart = true;
			
			foreach (var symbol in phrase)
			{
				if ((symbol >= 'A' && symbol <= 'Z') ||
				    (symbol >= 'a' && symbol <= 'z') ||
				    symbol == '\'')
				{
					if (wordStart)
					{
						result.Append(symbol);
					}

					wordStart = false;
				}
				else
				{
					wordStart = true;
				}

			}

			return result.ToString().ToUpper();
		}
	}
}