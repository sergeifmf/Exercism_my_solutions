// This file was auto-generated based on version 1.4.0 of the canonical data.

using System.Linq;
using System.Text.RegularExpressions;

namespace Bob
{
    public static class Bob
    {
        /// <summary>
        /// Realizing answers of lackadaisical teenager Bob.
        /// </summary>
        /// <param name="statement"> Phrase to Bob. </param>
        /// <returns> Bob's answer. </returns>
        public static string Response(string statement)
        {
            statement = statement.Trim();

            var isContainLetters = statement.Any(char.IsLetter);
            
            var isLastCharQuestion = statement.EndsWith("?");

            var isPhraseInUpper = statement.All(charac => !char.IsLetter(charac) || char.IsUpper(charac));

            var isEmptyPhrase = string.IsNullOrEmpty(statement) || string.IsNullOrWhiteSpace(statement);

            if (isEmptyPhrase)
            {
                return "Fine. Be that way!";
            }

            if (isLastCharQuestion && isPhraseInUpper && isContainLetters)
            {
                return "Calm down, I know what I'm doing!";
            }

            if (isLastCharQuestion)
            {
                return "Sure.";
            }

            return (isPhraseInUpper && isContainLetters) ? "Whoa, chill out!" : "Whatever.";
        }
    }
}