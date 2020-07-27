using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int total = 0;
        HashSet<int> nums = new HashSet<int>();

        foreach (int val in myList)
        {
            if (!nums.Contains(val))
            {
                total += val;
                nums.Add(val);
            }
        }

        return total;
    }
}
