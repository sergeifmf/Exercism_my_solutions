using System.Collections.Generic;
using System.Linq;

namespace SecretHandshake
{
    public static class SecretHandshake
    {
        /// <summary>
        /// Given a decimal number, convert it to the appropriate sequence of events for a secret handshake.
        /// </summary>
        /// <param name="commandValue">Appropriate sequence of events for a secret handshake.</param>
        /// <returns></returns>
        public static string[] Commands(int commandValue)
        {
            var reverse = true;
            var commands = new List<string>();

            var secretHandshake = new Dictionary<int, string>()
            {
                { 1, "wink" },
                { 2, "double blink" },
                { 4, "close your eyes" },
                { 8, "jump" },
                { 16, "" },
            }.OrderByDescending(item => item.Key);

            foreach (var (key, value) in secretHandshake)
            {
                if ((commandValue & key) == key)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        reverse = false;
                    }
                    else
                    {
                        commands.Add(value);
                    }                        
                }

                commandValue -= key;
            }

            if (reverse)
            {
                commands.Reverse();
            }
            
            return commands.ToArray();

        }

    }
}
