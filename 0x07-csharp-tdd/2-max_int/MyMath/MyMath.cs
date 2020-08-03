using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Class for basic math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Gets the maximum number in a list
        /// </summary>
        /// <param name="nums">A list of integers</param>
        /// <returns>The largest number in the list</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
                return 0;

            return nums.Max();
        }
    }
}
