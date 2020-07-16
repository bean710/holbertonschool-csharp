using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        if (myDict == null)
        {
            return null;
        }

        Dictionary<string, int> ret = new Dictionary<string, int>();

        foreach (string key in myDict.Keys)
        {
            ret.Add(key, myDict[key] * 2);
        }

        return ret;
    }
}