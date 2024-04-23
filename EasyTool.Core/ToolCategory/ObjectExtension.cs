using System;
using System.Collections;

namespace EasyTool
{
    /// <summary>
    /// 对象扩展方法类
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// 检查对象是否为空（null 或者 空字符串或空白字符 或者 空集合）
        /// </summary>
        public static bool IsNullOrEmpty(this object obj)
        {
            if (obj == null)
            {
                return true;
            }

            if (obj is string str)
            {
                return string.IsNullOrWhiteSpace(str);
            }

            if (obj is ICollection collection)
            {
                return collection.Count == 0;
            }

            return false;
        }

        /// <summary>
        /// 检查对象是否不为空（不为 null 且不为空字符串或空白字符或空集合）
        /// </summary>
        public static bool IsNotNullOrEmpty(this object obj)
        {
            return !IsNullOrEmpty(obj);
        }
    }
}
