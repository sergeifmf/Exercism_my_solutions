namespace Leap
{
    public static class Leap
    {
        /// <summary>
        /// Define, is given year leap.
        /// </summary>
        /// <param name="year"> Given year. </param>
        /// <returns> Is given year leap. </returns>
        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || (year % 400 == 0));
        }
    }
}