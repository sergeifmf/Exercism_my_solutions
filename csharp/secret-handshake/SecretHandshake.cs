using System;
using System.Collections.Generic;

namespace SecretHandshake
{
    /// <summary>
    /// Given a decimal number, convert it to the appropriate sequence of events for a secret handshake.
    /// </summary>
    public static class SecretHandshake
    {
        private static readonly List<string> secretHandshake = new List<string>()
            { "wink", "double blink", "close your eyes", "jump", "", };
        
        private static void AddToList(int convertNumber, int number, ref List<string> words)
        {
            var value = Convert.ToInt32(Math.Pow(2, number));

            if ((convertNumber & value) == value)
            {
                words.Add(secretHandshake[number]);
            }
        }
       
        public static string[] Commands(int commandValue)
        {
            var commands = new List<string>();
            var secretHandshakeLength = secretHandshake.Count;

            AddToList(commandValue, secretHandshakeLength - 1, ref commands);

            if (commands.Count != 0)
            {
                commands.Clear();

                for (var i = secretHandshakeLength - 2; i >= 0; i--)
                {
                    AddToList(commandValue, i, ref commands);
                }
            }
            else
            {
                for (var i = 0; i < secretHandshakeLength - 1; i++)
                {
                    AddToList(commandValue, i, ref commands);
                }
            }

            return commands.ToArray();

        }

    }
}
