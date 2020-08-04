using System;

namespace Text
{
    /// <summary>
    /// Class for string helper methods
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Gets the number of words in a camel-cased string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CamelCase(string s)
        {
            int wordCount = 0;

            if (s == null)
                return 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (wordCount == 0)
                {
                    if (c >= 'a' && c <= 'z')
                        wordCount++;
                }
                else
                {
                    if (c >= 'A' && c <= 'Z')
                        wordCount++;
                }
            }

            return wordCount;
        }
    }
}
