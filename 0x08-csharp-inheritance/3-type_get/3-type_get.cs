using System;
using System.Reflection;

/// <summary>
/// Class for object methods
/// </summary>
class Obj
{
    /// <summary>
    /// Prints names of properties and methods of an object
    /// </summary>
    /// <param name="myObj">The object to get properties and methods of</param>
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();

        Console.WriteLine($"{t.Name} Properties:");
        foreach (PropertyInfo p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }

        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}