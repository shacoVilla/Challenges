// <copyright file="ReverseHelper.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ReverseKigo
{
    using System;

    /// <summary>
    /// The Reverse helper.
    /// </summary>
    public static class ReverseHelper
    {
        /// <summary>
        /// The method that reverts a string by using a XOR operation by using a char array that represents a string.
        /// </summary>
        /// <param name="s">The string to be reverted.</param>
        /// <returns>A <see cref="string"/> value.</returns>
        public static string ReverseTextByBit(string s)
        {
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            return new string(charArray);
        }

        /// <summary>
        /// Reverse the text by character.
        /// </summary>
        /// <param name="s">The value to be reverted.</param>
        /// <returns>A <see cref="string"/>.</returns>
        public static string ReverseTextByChar(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
