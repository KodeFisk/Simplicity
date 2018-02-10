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
        /// <param name="This">The <c>string</c> to check</param>
        /// <param name="minimumLength">The minimum required length</param>
        /// <returns>Returns <c>true</c> if the string is not null and is at least the minimum specified length, else <c>false</c></returns>
        public static bool HasValue(this string This, int minimumLength = 1) => !string.IsNullOrWhiteSpace(This) && This.Length >= minimumLength;
    }
}
