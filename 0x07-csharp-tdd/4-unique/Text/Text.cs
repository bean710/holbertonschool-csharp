using System;

namespace Text
{
    /// <summary>
    /// Class containing methods for strings.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Finds the index of the first non-repeating character of a string.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The index of the first unique character, or -1 if none found.</returns>
        public static int UniqueChar(string s)
        {
            int[] counter = new int[26];

            if (s == null)
                return -1;

            foreach (char c in s.ToCharArray())
            {
                counter[c - 'a'] += 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (counter[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}
