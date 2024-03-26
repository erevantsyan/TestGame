using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class Extensions
{
    public static T[] RemoveAt<T>(this T[] source, int index)
    {
        return source.Where((_, i) => i != index).ToArray();
    }
}

public static class StaticCount
{
    public static string findLast;

    public static int TrueAns;

    public static int lvlCount = 0; 

    public static int rotationCount = 0;
}
