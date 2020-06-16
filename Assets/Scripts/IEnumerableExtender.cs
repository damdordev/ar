using System;
using System.Collections;
using System.Collections.Generic;

public static class IEnumerableExtender 
{

    public static void Foreach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        foreach (var v in enumerable)
        {
            action(v);
        }
    }
    
    public static void Foreach(this IEnumerable enumerable, Action<object> action)
    {
        foreach (var v in enumerable)
        {
            action(v);
        }
    }
    
}
