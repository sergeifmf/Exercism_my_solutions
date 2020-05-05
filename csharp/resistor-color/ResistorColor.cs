using System;

namespace ResistorColor
{
	public static class ResistorColor
	{
		private static readonly string[] ResistorColorCodes = 
			{"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

		/// <summary>
		/// Finds resistor number by name.
		/// </summary>
		/// <param name="color"> Resistor color. </param>
		/// <returns> Resistor number. </returns>
		public static int ColorCode(string color)
		{
			return Array.FindIndex(ResistorColorCodes, value => value == color);
		}

		/// <summary>
		/// Returns all resistor colors.
		/// </summary>
		/// <returns> Resistor colors. </returns>
		public static string[] Colors()
		{
			return ResistorColorCodes;
		}
	}
}