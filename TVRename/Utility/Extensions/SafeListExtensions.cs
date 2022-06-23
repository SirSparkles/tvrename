using System.Collections.Generic;

namespace TVRename;

public static class SafeListExtensions
{
    public static SafeList<T> ToSafeList<T>(this IEnumerable<T> source)
    {
        SafeList<T> retValue = new();
        retValue.AddNullableRange(source);
        return retValue;
    }
}
