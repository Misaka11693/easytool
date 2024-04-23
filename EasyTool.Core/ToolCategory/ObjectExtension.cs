using System;
using System.Collections;

public static class ObjectExtensions
{
    /// <summary>
    /// 检查对象不为空（不为 null 且不为空字符串或空白字符）
    /// </summary>
    public static bool IsNotEmpty(this object obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj is string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        if (obj is ICollection collection)
        {
            return collection.Count == 0;
        }

        return true;
    }
}
