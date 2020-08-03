using System;

namespace Text
{
    /// <summary>
    /// Class for string functions
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if palindrome, otherwise false.</returns>
        public static bool IsPalindrome(string s)
        {
            string normalized = "";

            for (int q = 0; q < s.Length; q++)
            {
                char c = s[q];

                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    normalized += Char.ToLower(c);
                }
            }

            int i = 0;
            int j = normalized.Length - 1;

            while (i < j)
            {
                if (normalized[i] != normalized[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
