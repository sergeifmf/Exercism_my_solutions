namespace TwoFer
{
	public static class TwoFer
	{
		public static string Name(string input = null)
		{
			var output = string.IsNullOrEmpty(input) ? "you" : input;
			return $"One for {output}, one for me.";
		}
	}
}
