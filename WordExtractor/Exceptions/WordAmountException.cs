// <copyright file="WordAmountException.cs" company="KIGO">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace WordExtractor.Exceptions
{
    using System;

    /// <summary>
    /// The Invalidad amount of words by position exception. See <see cref="Exception"/>.
    /// </summary>
    public class WordAmountException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WordAmountException"/> class.
        /// </summary>
        /// <param name="wordsCount">The amount of words in the text.</param>
        /// <param name="position">The position where a word should be founded.</param>
        public WordAmountException(int wordsCount, int position)
           : base(GetMessage(wordsCount, position))
        {
        }

        private static string GetMessage(int words, int position) => $"Can't extract a word in the position {position} " +
                $"of a text that has only {words} {(position == 1 ? "word" : "words")}";
    }
}
