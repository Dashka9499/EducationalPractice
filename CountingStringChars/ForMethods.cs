using System;
using System.Globalization;

namespace CountingStringChars
{
    public static class ForMethods
    {
        /// <summary>
        /// Returns a number of characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of characters in a string.</returns>
        public static int GetCharCount(string? str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Length;
        }

        /// <summary>
        /// Returns a number of upper characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of upper characters in a string.</returns>
        public static int GetUpperCharCount(string? str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int k = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == char.ToUpper(str[i], CultureInfo.CreateSpecificCulture("en-US")))
                {
                    k++;
                }
            }

            return k;
        }

        /// <summary>
        /// Returns a number of characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of characters in a string.</returns>
        public static int GetCharCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharCountRecursive(str, 0);
        }

        /// <summary>
        /// Returns a number of upper characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of upper characters in a string.</returns>
        public static int GetUpperCharCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetUpperCharCountRecursive(str, 0);
        }

        private static int GetCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharCountRecursive(str, index + 1) + 1;
        }

        private static int GetUpperCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            bool isUpper = char.IsUpper(str[index]);
            int currentIncrement = isUpper ? 1 : 0;

            return GetUpperCharCountRecursive(str, index + 1) + currentIncrement;
        }
    }
}
