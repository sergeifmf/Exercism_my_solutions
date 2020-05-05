using System;

namespace Hamming
{
    public static class Hamming
    {
        /// <summary>
        /// Calculate the Hamming Distance between two DNA strands. 
        /// </summary>
        /// <param name="firstStrand"> First strand. </param>
        /// <param name="secondStrand"> Second strand. </param>
        /// <returns> Hamming distance. </returns>
        public static int Distance(string firstStrand, string secondStrand)
        {
            try
            {
                var dnaLength = firstStrand.Length;

                if (secondStrand.Length != dnaLength)
                {
                    throw new ArgumentException("Arguments has different length");
                }

                var result = 0;

                for (var i = 0; i < dnaLength; i++)
                {
                    if (firstStrand[i] != secondStrand[i])
                    {
                        result++;
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}