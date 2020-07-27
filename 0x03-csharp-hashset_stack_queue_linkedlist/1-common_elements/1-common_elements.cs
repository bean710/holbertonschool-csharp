using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common = new List<int>();

        foreach (int val in list1)
        {
            if (list2.Contains(val))
            {
                common.Add(val);
            }
        }

        return common;
    }
}
