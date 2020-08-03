using System;

namespace Text
{
    /// <summary>
    /// Class containing methods for strings.
    /// </summary>
    public class Str
    {
        public static int UniqueChar(string s)
        {
            int[] counter = new int[26];

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
