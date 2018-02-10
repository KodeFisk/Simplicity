using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class SystemMixins
    {
        /// <summary>
        /// Checks if the string has a value of at least the minimum lengt.
        /// </summary>
        /// <param name="This">The <c>string</c> to check.</param>
        /// <param name="minimumLength">The minimum required length.</param>
        /// <returns>Returns <c>true</c> if the string is not null and is at least the minimum specified length, else <c>false</c>.</returns>
        public static bool HasValue(this string This, int minimumLength = 1) => !string.IsNullOrWhiteSpace(This) && This.Length >= minimumLength;

        /// <summary>
        /// Calls the specified action, where the object can be mutated, and returns the same instance.
        /// This is useful for making multiple changes to an object in a single expression.
        /// </summary>
        /// <param name="This">The object to be mutated.</param>
        /// <param name="mutation">An action that makes changes to the object.</param>
        /// <typeparam name="T">The type of the object to be mutated.</typeparam>
        /// <returns>The same instance of the object</returns>
        public static T Mutate<T>(this T This, Action<T> mutation)
        {
            mutation(This);
            return This;
        }

        /// <summary>
        /// Assigns the object instance to the specified variable.
        /// This is useful as a more readable way to assign to a variable.
        /// </summary>
        /// <param name="This">The object instance to be assigned.</param>
        /// <param name="variable">The variable to assign the object instance.</param>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <returns>The same object instance.</returns>
        public static T Assign<T>(this T This, out T variable) => variable = This;
    }
}
