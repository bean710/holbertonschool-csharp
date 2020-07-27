using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> uncommon = new List<int>();

        foreach (int val in list1)
        {
            if (!list2.Contains(val))
            {
                uncommon.Add(val);
            }
        }

        foreach (int val in list2)
        {
            if (!list1.Contains(val))
            {
                uncommon.Add(val);
            }
        }

        uncommon.Sort();
        return uncommon;
    }
}
