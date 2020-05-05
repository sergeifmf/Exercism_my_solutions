using System;

namespace Gigasecond
{
	public static class Gigasecond
	{
		/// <summary>
		/// Given a moment, determines the moment that would be after a gigasecond has passed
		/// </summary>
		/// <param name="moment">Count gigaseconds</param>
		/// <returns>Result moment.</returns>
		public static DateTime Add(DateTime moment)
		{
			const int gigasecond = 1000000000;
			return moment.AddSeconds(gigasecond);
		}
	}
}