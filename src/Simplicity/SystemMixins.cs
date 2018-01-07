using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class SystemMixins
    {
        /// <summary>
        /// Checks if the string has a value of at least the minimum length
        /// </summary>
        /// <param name="source">The <c>string</c> to check</param>
        /// <param name="minimumLength">The minimum required length</param>
        /// <returns>Returns <c>true</c> if the string is not null and is at least the minimum specified length, else <c>false</c></returns>
        public static bool HasValue(this string source, int minimumLength = 1) => !string.IsNullOrWhiteSpace(source) && source.Length >= minimumLength;

        /// <summary>
        /// Write to the Debug output and return the original object unmodified
        /// </summary>
        /// <param name="source">The object to write to the Debug output</param>
        /// <param name="selector">A <c>Func</c> that selects the property to be written</param>
        /// <param name="prefix">A prefix to write before the output. Use this to easily identify individual <c>Dump</c>s</param>
        /// <typeparam name="T">The type of the object to write to the Debug output</typeparam>
        /// <returns>The original object</returns>
        public static T Dump<T>(this T source, Func<T, object> selector, string prefix = "")
        {
            System.Diagnostics.Debug.WriteLine($"{prefix}{(prefix.HasValue() ? ": " : "")}{selector(source)}");
            return source;
        }

        /// <summary>
        /// Write to the Debug output and return the original object unmodified
        /// </summary>
        /// <param name="source">The object to write to the Debug output</param>
        /// <param name="prefix">A prefix to write before the output. Use this to easily identify individual <c>Dump</c>s</param>
        /// <typeparam name="T">The type of the object to write to the Debug output</typeparam>
        /// <returns>The original object</returns>
        public static T Dump<T>(this T source, string prefix = "") => source.Dump(value => value, prefix);
    }
}
